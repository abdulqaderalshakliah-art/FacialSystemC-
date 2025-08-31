-- Create Database
CREATE DATABASE FacialSystem;



-- 1. Faculties Table
CREATE TABLE Faculties (
    faculty_id INT IDENTITY(1,1) PRIMARY KEY,
    faculty_name NVARCHAR(100) NOT NULL,
   
    
);


-- 2. Departments Table
CREATE TABLE Departments (
    department_id INT IDENTITY(1,1) PRIMARY KEY,
    department_name NVARCHAR(100) NOT NULL,
    faculty_id INT NOT NULL,
    FOREIGN KEY (faculty_id) REFERENCES Faculties(faculty_id)
);


-- 3. Students Table
CREATE TABLE Students (
    student_id INT IDENTITY(1,1) PRIMARY KEY,
    student_code NVARCHAR(20) UNIQUE NOT NULL,
    first_name NVARCHAR(50) NOT NULL,
    last_name NVARCHAR(50) NOT NULL,
    email NVARCHAR(100),
    phone NVARCHAR(20),
    photo VARBINARY(MAX), -- Store facial image data
    department_id INT NOT NULL,
    is_active BIT DEFAULT 1,
    FOREIGN KEY (department_id) REFERENCES Departments(department_id)
);

-- 4. Instructors Table
CREATE TABLE Instructors (
    instructor_id INT IDENTITY(1,1) PRIMARY KEY,
    first_name NVARCHAR(50) NOT NULL,
    last_name NVARCHAR(50) NOT NULL,
    email NVARCHAR(100),
    phone NVARCHAR(20),
    username NVARCHAR(50) UNIQUE NOT NULL,
    password_hash NVARCHAR(255) NOT NULL,
    department_id INT NOT NULL,
    FOREIGN KEY (department_id) REFERENCES Departments(department_id)
);
GO

-- 5. Courses Table
CREATE TABLE Courses (
    course_id INT IDENTITY(1,1) PRIMARY KEY,
    course_name NVARCHAR(100) NOT NULL,
    course_code NVARCHAR(20) UNIQUE NOT NULL,
    department_id INT NOT NULL,
    instructor_id INT NOT NULL,
    FOREIGN KEY (department_id) REFERENCES Departments(department_id),
    FOREIGN KEY (instructor_id) REFERENCES Instructors(instructor_id)
);


-- 6. Semesters Table
CREATE TABLE Semesters (
    semester_id INT IDENTITY(1,1) PRIMARY KEY,
    semester_name NVARCHAR(50) NOT NULL, -- Fall, Spring, Summer
    academic_year NVARCHAR(20) NOT NULL, -- 2024/2025
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    
);
GO

-- 7. Enrollments Table
CREATE TABLE Enrollments (
    enrollment_id INT IDENTITY(1,1) PRIMARY KEY,
    student_id INT NOT NULL,
    course_id INT NOT NULL,
    semester_id INT NOT NULL,
    enrollment_date DATE DEFAULT GETDATE(),
    FOREIGN KEY (student_id) REFERENCES Students(student_id),
    FOREIGN KEY (course_id) REFERENCES Courses(course_id),
    FOREIGN KEY (semester_id) REFERENCES Semesters(semester_id),
    UNIQUE(student_id, course_id, semester_id) -- Prevent duplicate enrollments
);
GO

-- 8. ClassSessions Table
CREATE TABLE ClassSessions (
    session_id INT IDENTITY(1,1) PRIMARY KEY,
    course_id INT NOT NULL,
    semester_id INT NOT NULL,
    session_date DATE NOT NULL,
    start_time TIME NOT NULL,
    end_time TIME NOT NULL,
    room NVARCHAR(50),
    FOREIGN KEY (course_id) REFERENCES Courses(course_id),
    FOREIGN KEY (semester_id) REFERENCES Semesters(semester_id)
);
GO

-- 9. Attendance Table
CREATE TABLE Attendance (
    attendance_id INT IDENTITY(1,1) PRIMARY KEY,
    student_id INT NOT NULL,
    session_id INT NOT NULL,
    status NVARCHAR(20) DEFAULT 'Present', -- Present, Absent, Late
    timestamp DATETIME DEFAULT GETDATE(),
    face_verified BIT DEFAULT 0,
    confidence_score FLOAT NULL, -- Face recognition confidence percentage
    captured_image NVARCHAR(255) NULL, -- Path to captured image for verification
    FOREIGN KEY (student_id) REFERENCES Students(student_id),
    FOREIGN KEY (session_id) REFERENCES ClassSessions(session_id),
    UNIQUE(student_id, session_id) -- One attendance record per student per session
);
GO

-- 10. Admins Table
CREATE TABLE Admins (
    admin_id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) UNIQUE NOT NULL,
    password_hash NVARCHAR(255) NOT NULL,
    first_name NVARCHAR(50) NOT NULL,
    last_name NVARCHAR(50) NOT NULL,
    email NVARCHAR(100),
    role NVARCHAR(20) DEFAULT 'Admin', -- SuperAdmin, FacultyAdmin
  
);



