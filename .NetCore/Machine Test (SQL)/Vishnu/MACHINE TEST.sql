CREATE DATABASE MARKS_EVALUATION;
USE MARKS_EVALUATION;

CREATE TABLE Students_table(StudentID INT PRIMARY KEY,StudentNAME VARCHAR(50),Class INT);
INSERT INTO Students_table(StudentID,StudentNAME,Class)
VALUES
(1,'Rahul',10),
(2,'Shena',10),
(3,'Amit' , 9),
(4,'Priya',10);

CREATE TABLE MARKS_table(MarkID INT PRIMARY KEY,StudentID INT,Subject VARCHAR(50),Marks INT,FOREIGN KEY(StudentID) REFERENCES Students_table(StudentID) );
INSERT INTO MARKS_table(MarkID,StudentID,Subject,Marks) 
VALUES 
(1,1,'MATH',80),
(2,1,'SCIENCE',70),
(3,2,'MATH',90),
(4,3,'SCIENCE',60);

SELECT * FROM Students_table;
SELECT * FROM MARKS_table;

SELECT 
Students_table.StudentID,
Students_table.StudentNAME,
SUM(MARKS_table.Marks) AS Total_Marks
FROM Students_table 
JOIN MARKS_table 
ON Students_table.StudentID = MARKS_table.StudentID
GROUP BY 
Students_table.StudentID, Students_table.StudentNAME;


SELECT 
Students_table.StudentID,
Students_table.StudentNAME
FROM Students_table 
LEFT JOIN MARKS_table 
ON Students_table.StudentID = MARKS_table.StudentID
WHERE MARKS_table.StudentID IS NULL;


SELECT  MAX(Marks) 
AS Highet_MATH_Marks
FROM MARKS_table
WHERE Subject = 'MATH';

SELECT Subject,AVG(Marks) 
AS AverageMarks
FROM MARKS_table
GROUP BY Subject;

SELECT 
Students_table.StudentID,
Students_table.StudentNAME
FROM Students_table 
JOIN MARKS_table 
ON Students_table.StudentID = MARKS_table.StudentID
WHERE MARKS_table.Marks > 75;













