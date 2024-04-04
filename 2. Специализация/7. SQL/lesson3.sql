create database lesson3;
use lesson3;

/* -- ангрегирующие фукции  -- */ 

CREATE TABLE staff
(id INT auto_increment not null primary key,
firstname varchar(45) not null,
lastname varchar(45) not null,
post varchar(45) not null,
seniority int unsigned not null,
salary bigint unsigned not null,
age int unsigned not null);

INSERT INTO staff
(firstname, lastname, post, seniority, salary, age)
VALUES
('Вася', "Васькин", "начальник", 40, 100000, 60),
('Петя', "Петькин", "начальник", 8, 70000, 30),
('Катя', "Каткина", "инженер", 2, 70000, 25),
('Саша', "Сашкин", "инженер", 12, 50000, 35),
('Иван', "Иванов", "рабочий", 40, 30000, 59),
('Петр', "Петров", "рабочий", 20, 25000, 40),
('Сидор', "Сидоров", "рабочий", 10, 20000, 35),
('Антон', "Антонов", "рабочий", 8, 19000, 28),
('Юра', "Юркин", "рабочий", 5, 15000, 25),
('Максим', "Воронин", "рабочий", 2, 11000, 22),
('Юра', "Галкин", "рабочий", 3, 12000, 24),
('Люся', "Люськина", "уборщик", 10, 10000, 49);

-- сортировка по возрасту
SELECT * FROM staff
ORDER BY age;

-- Выведите все записи, отсортированные по полю “firstname"
SELECT * FROM staff
ORDER BY firstname;

-- Выведите записи полей "firstname ", “lastname", "age", отсортированные по полю "firstname " в алфавитном порядке по убыванию
SELECT firstname, lastname, age FROM staff
ORDER BY firstname desc;

-- Выполните сортировку по полям " firstname " и "age" по убыванию
SELECT * FROM staff
ORDER BY firstname desc, age desc;



-- 1. Выведите уникальные (неповторяющиеся) значения полей "firstname"
SELECT DISTINCT firstname FROM staff;

-- 2. Отсортируйте записи по возрастанию значений поля "id". Выведите первые две записи данной выборки
SELECT * FROM staff
ORDER BY id
LIMIT 2;

-- 3. Отсортируйте записи по возрастанию значений поля "id". Пропустите первые 4 строки данной выборки и извлеките следующие 3
SELECT * FROM staff
ORDER BY id
LIMIT 4, 3;

-- 4. Отсортируйте записи по убыванию поля "id". Пропустите две строки данной выборки и извлеките следующие за ними 3 строки
SELECT * FROM staff
ORDER BY id DESC
LIMIT 2, 3;



-- 1. Найдите количество сотрудников с должностью «Рабочий»
SELECT COUNT(*) AS worker
FROM staff
WHERE post = 'рабочий';

-- 2. Посчитайте ежемесячную зарплату начальников
SELECT SUM(salary)
FROM staff
WHERE post = 'начальник';

-- 3. Выведите средний возраст сотрудников, у которых заработная плата больше 30000
SELECT AVG(age)
FROM staff
WHERE salary > 30000;

-- 4. Выведите максимальную и минимальную заработные платы
SELECT MAX(salary) AS MAX_SAL, MIN(salary) AS MIN_SAL
FROM staff;



CREATE TABLE activity_staff
(id INT auto_increment not null primary key,
name varchar(45),
work_date DATE,
pages INT);

INSERT INTO activity_staff
(name, work_date, pages)
VALUES
('John', "2007-01-24", 250),
('Ram', "2007-05-27", 220),
('Jack', "2007-05-06", 170),
('Jack', "2007-04-06", 100),
('Jill', "2007-04-06", 220),
('Zara', "2007-06-06", 300),
('Zara', "2007-02-06", 350);

-- 1. Выведите общее количество напечатанных страниц каждым сотрудником
SELECT name, SUM(pages) AS pagesSum
FROM activity_staff
GROUP BY name;

-- 2. Посчитайте количество страниц за каждый день
SELECT work_date, SUM(pages)
FROM activity_staff
GROUP BY work_date;

-- 3. Найдите среднее арифметическое по количеству страниц, напечатанных сотрудниками за каждый день
SELECT work_date, AVG(pages)
FROM activity_staff
GROUP BY work_date;


/*
Сгруппируйте данные о сотрудниках по возрасту:
1 группа – младше 20 лет
2 группа – от 20 до 40 лет
3 группа – старше 40 лет
Для каждой группы найдите суммарную зарплату*/
SELECT name_age, SUM(salary)
FROM
(SELECT salary,
CASE
	WHEN age < 20
		THEN 'Младше 20 лет'
	WHEN age between 20 AND 40
		THEN 'от 20 до 40 лет'
	WHEN age > 40
		THEN 'Старше 40 лет'
	ELSE 'Не определено'
END AS name_age
FROM staff ) AS list
GROUP BY name_age;



-- 1. Выведите id сотрудников, которые напечатали более 500 страниц за все дни
SELECT id FROM activity_staff
GROUP BY id
HAVING SUM(pages) > 300;

SELECT name FROM activity_staff
GROUP BY name
HAVING SUM(pages) > 500;

-- 2. Выведите дни, когда работало более 3 сотрудников Также укажите кол-во сотрудников, которые работали в выбранные дни.
SELECT work_date, COUNT(pages) AS page_count
FROM activity_staff
GROUP BY work_date
HAVING page_count > 1;

-- 3. Выведите должности, у которых средняя заработная плата составляет более 30000
SELECT post
FROM staff
GROUP BY post
HAVING AVG(salary > 30000);


-- Посчитайте и выведите количество уникальных должностей, имеющихся у сотрудников в сущности 'staff'. 
SELECT COUNT(*) AS 'количество должностей'
FROM (SELECT DISTINCT post FROM staff) AS list;


-- Найдите средний возраст сотрудников по каждой должности из сущности staff.
-- Выведите только те должности, у которых средний возраст меньше 30 лет

SELECT post
FROM staff
GROUP BY post
HAVING AVG(age < 30);

SELECT post, AVG(age)
FROM staff
GROUP BY post;







