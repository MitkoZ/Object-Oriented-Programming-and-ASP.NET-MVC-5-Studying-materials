CREATE DATABASE db_Students USE db_Students CREATE TABLE Students(  
Id INT IDENTITY PRIMARY KEY,  
Name NVARCHAR(max),  
Gender NVARCHAR(10),  
Subjects NVARCHAR(max)  
);  
INSERT INTO Students  
VALUES  
(  
'James Cameron', 'Male', 'Objctive C'  
),  
('Max Payne', 'Male', 'C-Sharp'),  
('Lara Croft', 'Female', 'Java'),  
('Aiden Pearce', 'Male', 'C++'),  
(  
'Sam Fisher', 'Male', 'Ruby on Rails'  
),  
(  
'Iron Man', 'Male', 'Objective C'  
),  
('Black Widow', 'Female', 'C++'),  
(  
'Michael Nolan', 'Male', 'C-Sharp'  
),  
(  
'Trevor DSouza', 'Male', 'Asp.Net'  
)