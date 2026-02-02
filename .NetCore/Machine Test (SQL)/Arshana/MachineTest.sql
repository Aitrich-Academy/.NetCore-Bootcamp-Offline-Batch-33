create database Education
use Education

-- Creating table Student

create table Student(StudentID int primary key,StudentName varchar(25),Class int);
insert into Student values(1,'Rahul',10);
insert into Student values(2,'Sneha',10);
insert into Student values(3,'Amit',9);
insert into Student values(4,'Priya',9);


-- Creating table Marks

create table Marks(MarkID int primary key,StudentID int,Subject varchar(25),Marks int, foreign key(StudentID)references Student(StudentID));
insert into Marks values(1,1,'Math',80);
insert into Marks values(2,1,'Science',70);
insert into Marks values(3,2,'Math',90);
insert into Marks values(4,3,'Math',60);

select * from Marks
select * from Student


-- Total Marks scored by each student.

select s.StudentID, s.StudentName,
Sum(m.Marks) as TotalMarks
from Student s
left join Marks m on s.StudentID = m.StudentID
group by s.StudentID, s.StudentName;


-- Students who have not received any marks

select s.StudentID, s.StudentName
from Student s
left join Marks m on s.StudentID = m.StudentID
where m.StudentID is null;


-- Highest marks scored in math

select max(Marks) as HighestMath
from Marks
where Subject = 'Math';


-- Average marks per subject.

select Subject,avg(Marks) as avgMarks
from Marks
group by Subject;


-- Students who scored more than 75 marks in any subject.

select distinct s.StudentID, s.StudentName
from Student s
join Marks m on s.StudentID = m.StudentID
where m.Marks > 75;
   
