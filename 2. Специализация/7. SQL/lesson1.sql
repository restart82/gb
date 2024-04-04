CREATE DATABASE lesson1;
USE lesson1;
CREATE TABLE students
(id int auto_increment not null primary key,
name_student varchar(45) not null,
course_name varchar(45) not null,
date_of_birth date not null,
email varchar(45),
phone_number bigint UNSIGNED);

CREATE TABLE teacher
(id int auto_increment not null primary key,
name_teacher varchar(45) not null,
post varchar(45) not null,
course_name varchar(45) not null);

CREATE TABLE course
(id int auto_increment not null primary key,
name_student varchar(45) not null,
name_teacher varchar(45) not null,
name_course varchar(45) not null);

INSERT INTO students
(name_student, course_name, date_of_birth, email, phone_number)
VALUES
('Миша', 'БД', '2000-01-26', 'misha@mail.ru', 9876543221),
('Антон', 'PHP', '000-07-12', 'anton@mail.ru', 9876543222),
('Маша', 'Аналитика', '2000-11-26', 'masha@mail.ru', 9876543223),
('Паша', 'no', '2000-06-24', 'pasha@mail.ru', 9876543224);

INSERT INTO teacher
(name_teacher, post, course_name)
VALUES
('Иванов И.И.', 'Профессор', 'БД'),
('Петров П.П.', 'Преподаватель', 'PHP'),
('Сидоров С.С.', 'Доцент', 'Аналитика');

INSERT INTO course
(name_student, name_teacher, name_course)
VALUES
('БД', 'Иванов И.И.', 'Миша'),
('PHP', 'Петров П.П.', 'Антон'),
('Аналитика', 'Сидоров С.С.', 'Маша');

SELECT * FROM students
WHERE name_student='Антон';

