CREATE DATABASE student_assessment_db;
USE student_assessment_db;

CREATE TABLE users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    role ENUM('Admin','Teacher','Student') NOT NULL,
    fullname VARCHAR(100),
    status ENUM('Active','Inactive') DEFAULT 'Active'
);

CREATE TABLE subjects (
    subject_id INT AUTO_INCREMENT PRIMARY KEY,
    subject_name VARCHAR(100) NOT NULL
);

CREATE TABLE exams (
    exam_id INT AUTO_INCREMENT PRIMARY KEY,
    subject_id INT,
    teacher_id INT,
    exam_title VARCHAR(100) NOT NULL,
    time_limit INT,
    schedule DATETIME,
    FOREIGN KEY(subject_id) REFERENCES subjects(subject_id),
    FOREIGN KEY(teacher_id) REFERENCES users(user_id)
);

CREATE TABLE questions (
    question_id INT AUTO_INCREMENT PRIMARY KEY,
    exam_id INT,
    question_text TEXT NOT NULL,
    correct_answer TEXT NOT NULL,
    FOREIGN KEY(exam_id) REFERENCES exams(exam_id)
);

CREATE TABLE choices (
    choice_id INT AUTO_INCREMENT PRIMARY KEY,
    question_id INT,
    choice_text TEXT NOT NULL,
    FOREIGN KEY(question_id) REFERENCES questions(question_id)
);

CREATE TABLE student_answers (
    answer_id INT AUTO_INCREMENT PRIMARY KEY,
    student_id INT,
    exam_id INT,
    question_id INT,
    chosen_answer TEXT,
    is_correct TINYINT(1),
    FOREIGN KEY(student_id) REFERENCES users(user_id),
    FOREIGN KEY(exam_id) REFERENCES exams(exam_id),
    FOREIGN KEY(question_id) REFERENCES questions(question_id)
);

CREATE TABLE scores (
    score_id INT AUTO_INCREMENT PRIMARY KEY,
    student_id INT,
    exam_id INT,
    score INT,
    date_taken DATETIME,
    FOREIGN KEY(student_id) REFERENCES users(user_id),
    FOREIGN KEY(exam_id) REFERENCES exams(exam_id)
);

INSERT INTO users (username, password, role, fullname) VALUES
('admin', SHA2('admin123', 256), 'Admin', 'System Administrator'),
('teacher1', SHA2('teach123', 256), 'Teacher', 'Sample Teacher'),
('student1', SHA2('stud123', 256), 'Student', 'Sample Student');

INSERT INTO subjects (subject_name) VALUES
('Mathematics'),
('English'),
('Science');

INSERT INTO exams (subject_id, teacher_id, exam_title, time_limit, schedule) VALUES
(1, 2, 'Math Quiz 1', 30, '2025-12-10 10:00:00');

INSERT INTO questions (exam_id, question_text, correct_answer) VALUES
(1, 'What is 2 + 2?', '4'),
(1, 'What is 5 x 3?', '15');

INSERT INTO choices (question_id, choice_text) VALUES
(1, '3'),
(1, '4'),
(1, '5');

INSERT INTO choices (question_id, choice_text) VALUES
(2, '8'),
(2, '15'),
(2, '10');
