CREATE DATABASE StudentManagement;
USE StudentManagement;

CREATE TABLE Students (StudentID INT PRIMARY KEY, StudentName VARCHAR(20), Class VARCHAR(10));
INSERT INTO Students (StudentID, StudentName, Class) 
VALUES (1, 'Rahul', '10'), (2, 'Sneha', '10'), (3, 'Amit', '9'), (4, 'Priya', '9');
SELECT * FROM Students;

CREATE TABLE Marks (MarkID INT PRIMARY KEY, StudentID INT, Subject VARCHAR(20), Marks INT, 
FOREIGN KEY (StudentID) REFERENCES Students(StudentID));
INSERT INTO Marks (MarkID, StudentID, Subject, Marks) 
VALUES (1, 1, 'Math', 80), (2, 1, 'Science', 70), (3, 2, 'Math', 90), (4, 3, 'Science', 60);
SELECT * FROM Marks;

SELECT 
    s.StudentID,
    s.StudentName,
    SUM(m.Marks) AS TotalMarks
FROM Students s
LEFT JOIN Marks m ON s.StudentID = m.StudentID
GROUP BY s.StudentID, s.StudentName;

SELECT 
    s.StudentID,
    s.StudentName,
    s.Class
FROM Students s
LEFT JOIN Marks m ON s.StudentID = m.StudentID
WHERE m.MarkID IS NULL;

SELECT MAX(Marks) AS HighestMathMark
FROM Marks
WHERE Subject = 'Math';


SELECT 
    s.StudentID,
    s.StudentName,
    m.Subject,
    m.Marks
FROM Students s
JOIN Marks m ON s.StudentID = m.StudentID
WHERE m.Marks > 75;

SELECT 
    Subject,
    AVG(Marks) AS AverageMarks
FROM Marks
GROUP BY Subject;