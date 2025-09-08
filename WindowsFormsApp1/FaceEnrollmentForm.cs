using System;

namespace WindowsFormsApp1
{
    internal class FaceEnrollmentForm
    {
        private int studentId;
        private string studentName;

        public FaceEnrollmentForm(int studentId, string studentName)
        {
            this.studentId = studentId;
            this.studentName = studentName;
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}