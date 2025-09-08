using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class loadfaculties
    {
            // ✅ جلب قائمة الكليات (اسم + ID)
            public static Dictionary<string, int> LoadFaculties()
            {
                var facultyMap = new Dictionary<string, int>();
                string sql = "SELECT faculty_id, faculty_name FROM Faculties ORDER BY faculty_name";

                using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader["faculty_name"].ToString();
                                int id = Convert.ToInt32(reader["faculty_id"]);
                                facultyMap[name] = id;
                            }
                        }
                    }
                }

                return facultyMap;
            }

            // ✅ جلب التخصصات حسب الكلية
            public static Dictionary<string, int> LoadMajorsByFaculty(int facultyId)
            {
                var majorMap = new Dictionary<string, int>();
                string sql = "SELECT department_id, department_name FROM Departments WHERE faculty_id = @FacultyId ORDER BY department_name";

                using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FacultyId", facultyId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader["department_name"].ToString();
                                int id = Convert.ToInt32(reader["department_id"]);
                                majorMap[name] = id;
                            }
                        }
                    }
                }

                return majorMap;
            }
        }
    }


