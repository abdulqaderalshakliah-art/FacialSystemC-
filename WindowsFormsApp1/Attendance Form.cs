
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
   
    public partial class Attendance_Form : Form
    {

        private VideoCapture videoCapture;
        private Mat frame;
        private bool isRunning = false;
        private CascadeClassifier faceDetector;
        

        public Attendance_Form()
        {
            InitializeComponent();
            // Load the face detection model
            string xmlPath = "haarcascade_frontalface_default.xml";

            // Make sure file exists
            if (!File.Exists(xmlPath))
            {
                MessageBox.Show("Error: haarcascade_frontalface_default.xml not found. Please add it to the project.");
                return;
            }

            faceDetector = new CascadeClassifier(xmlPath);

        }

        private void Attendance_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                try
                {
                    videoCapture = new VideoCapture(0); // Open default camera
                    videoCapture.ImageGrabbed += ProcessFrame;
                    videoCapture.Start();
                    isRunning = true;
                    lblStatus.Text = "Status: Camera Running";

                    // 🔍 Scan Studentsphotos folder and log attendance
                    DetectAndLogAttendanceFromFolder();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error starting camera: " + ex.Message, "Camera Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Status: Failed to Start";
                }
            }
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (videoCapture != null && imageBox1 != null)
            {
                frame = new Mat();
                videoCapture.Retrieve(frame);

                if (!frame.IsEmpty)
                {
                    CvInvoke.Flip(frame, frame, Emgu.CV.CvEnum.FlipType.Horizontal);

                    // Convert to grayscale
                    var gray = new Mat();
                    frame.ConvertTo(gray, Emgu.CV.CvEnum.DepthType.Cv8U, 1);

                    // Detect faces
                    var faces = faceDetector.DetectMultiScale(
                        gray,
                        1.1,
                        3,
                        new Size(30, 30),
                        new Size(200, 200)
                    );

                    // Draw rectangle around each face
                    foreach (var face in faces)
                    {
                        CvInvoke.Rectangle(
                            frame,
                            face,
                            new MCvScalar(0, 255, 0), // Green color
                            2                          // Thickness
                        );
                    }

                    // Update status
                    this.BeginInvoke((Action)(() =>
                    {
                        lblStatus.Text = faces.Length > 0 ? $"Status: {faces.Length} Face(s) Detected" : "Status: No Face";
                    }));

                    // Show result
                    imageBox1.Image = frame;
                }
            }
        }
        private void SaveAttendanceToSqlServer(int studentId, string status, DateTime attendanceDate, string remarks, TimeSpan recordedTime, string capturedImage)
        {
            DBconnection DB = new DBconnection();
            SqlConnection conn = DB.GetConnection();

            try
            {
                DB.Open();

                string checkQuery = @"SELECT COUNT(*) FROM Attendance 
                       WHERE student_id = @student_id AND timestamp = @attendance_date";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@student_id", studentId);
                    checkCmd.Parameters.AddWithValue("@attendance_date", attendanceDate);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                        return;
                }

                string insertQuery = @"INSERT INTO Attendance 
                        (student_id, status, timestamp, captured_image) 
                        VALUES 
                        (@student_id, @status, @attendance_date, @captured_image)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@student_id", studentId);
                    insertCmd.Parameters.AddWithValue("@status", status);
                    insertCmd.Parameters.AddWithValue("@attendance_date", attendanceDate);
                    insertCmd.Parameters.AddWithValue("@captured_image", capturedImage);

                    insertCmd.ExecuteNonQuery();
                }
            }
            finally
            {
                DB.Close();
            }
        }
        private void DetectAndLogAttendanceFromFolder()
        {
            string folderPath = @"C:\Users\lenovo\source\repos\FacialSystem\StudentsPhotos";
            string[] imageFiles = Directory.GetFiles(folderPath, "*.jpg");

            foreach (string file in imageFiles)
            {
                Mat img = CvInvoke.Imread(file, Emgu.CV.CvEnum.ImreadModes.ReducedColor8);
                if (!img.IsEmpty)
                {
                    Mat grayImg = new Mat();
                    CvInvoke.CvtColor(img, grayImg, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

                    var detectedFaces = faceDetector.DetectMultiScale(
                        grayImg,
                        1.1,
                        3,
                        new Size(30, 30),
                        new Size(200, 200)
                    );

                    if (detectedFaces.Length > 0)
                    {
                        int studentId = ExtractStudentIdFromFilename(file);
                        SaveAttendanceToSqlServer(
                            studentId,
                            "Present",
                            DateTime.Today,
                            "Auto-detected from Studentsphotos",
                            DateTime.Now.TimeOfDay,
                            Path.GetFileName(file)
                        );
                    }
                }
            }
        }
        private int ExtractStudentIdFromFilename(string filePath)
        {
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string[] parts = fileName.Split('_');
            if (parts.Length > 0 && int.TryParse(parts[0], out int studentId))
            {
                return studentId;
            }
            return 0;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (isRunning)
    {
        videoCapture.Stop();
        videoCapture.Dispose();
        videoCapture = null;
        imageBox1.Image = null;
        lblStatus.Text = "Status: Camera Stopped";
        isRunning = false;
    }
        }
       
   

        private void Attendance_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCapture != null)
            {
                videoCapture.Stop();
                videoCapture.Dispose();
                videoCapture = null;
            }
        }
    }
}






