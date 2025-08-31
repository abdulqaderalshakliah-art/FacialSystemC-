# 🎓 Facial Smart Attendance System

A modern university attendance system that uses **facial recognition** to automate student check-in. Built with **C# .NET**, **SQL Server**, and **Entity Framework**, this system replaces manual roll calls with secure, accurate, and real-time attendance tracking.

> 🔐 Secure Login | 📸 Image Path Storage | 📊 Report Ready | 🧠 PDF-Based Design

Groupwork:
Abdulqader
Yahya

## 📂 Overview

This system is built based on the **official database design** from the `facial smart attendence system.pdf`. It supports:
- Automated attendance using facial images
- Full academic structure: Faculties → Departments → Courses → Sessions
- Role-based access (Admin / Professor)
- Data reporting and export

All data is stored in a **relational SQL Server database** with 10 fully connected tables.

---

## 🛠️ Technologies Used

| Layer | Technology | Purpose |
|------|-----------|--------|
| **Frontend** | Windows Forms (C# .NET Framework) | User interface for admins |
| **Backend** | C# | Logic, validation, navigation |
| **Database** | SQL Server (LocalDB) | Stores all student, course, and attendance data |
| **ORM** | Entity Framework 6 (Database First) | Connects C# to SQL without writing raw queries |
| **Image Handling** | `PictureBox`, `System.Drawing`, `File.Copy()` | Manages student photos |
| **Security** | SHA256 Hashing | Secures admin passwords |
| **Export** | EPPlus (Excel) | Exports reports to `.xlsx` |

---



The database is **fully aligned** with your `facial smart attendence system.pdf`.  
All 10 tables are implemented with correct fields and relationships.

### 🔢 Main Tables

| Table | Key Fields | Purpose |
|------|-----------|--------|
| `Faculties` | `faculty_id`, `faculty_name` | Top-level academic units |
| `Departments` | `department_id`, `faculty_id(FK)` | Sub-units under faculties |
| `Students` | `student_id`, `first_name`, `last_name`, `photo`,phone, `department_id(FK)` | Stores student data and facial image path |
| `Instructors` | `instructor_id`, `first_name`, `last_name`, email,`department_id(FK)` | Faculty members |
| `Courses` | `course_id`, `course_name`, `course_code`, `instructor_id(FK)` | Academic courses |
| `Semester` | `semester_id`, `semester_name`, `academic_year`, `start_date`, `end_date` | Academic terms |
| `Enrollment` | `enrollment_id`, `student_id(FK)`, `course_id(FK)`, `semester_id(FK)` | Links students to courses per semester |
| `ClassSessions` | `session_id`, `course_id(FK)`, `session_date`, `start_time`, `room` | Individual lectures |
| `Attendance` | `attendance_id`, `student_id(FK)`, `session_id(FK)`, `status`, `face_verified`, `timestamp` | Tracks attendance with facial verification flag |
| `Admins` | `admin_id`, `username`, `password_hash`, `role` | Admin login with roles |

### 🔗 Key Relationships
- Faculty → 1:N → Departments
- Department → 1:N → Students, Instructors, Courses
- Course → 1:N → ClassSessions
- Student ↔ M:N ↔ Courses (via `Enrollment`)
- Student ↔ M:N ↔ ClassSessions (via `Attendance`)
- Semester → 1:N → Enrollment, ClassSessions

✅ All relationships are enforced via foreign keys.

---

## 🔌 How It Connects to the Database

The system uses **Entity Framework 6 (Database First)** to connect C# code to SQL Server.

### Steps:
1. Created `Model1.edmx` by importing from `FacialSmartAttendanceDB`
2. Generated:
   - `Model1.Context.cs` → Contains `Model1Entities : DbContext`
   - C# classes: `Student`, `Course`, `Attendance`, etc.
