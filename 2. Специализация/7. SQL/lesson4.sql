create database lesson4;
use lesson4;


-- JOIN
-- имеем 2 таблицы:

CREATE TABLE teacher
(
	id INT NOT NULL PRIMARY KEY,
	surname VARCHAR(45),
	salary INT
);
INSERT teacher
VALUES
(1,"Авдеев", 17000),
(2,"Гущенко",27000),
(3,"Пчелкин",32000),
(4,"Питошин",15000),
(5,"Вебов",45000),
(6,"Шарпов",30000),
(7,"Шарпов",40000),
(8,"Питошин",30000);
SELECT * FROM teacher;

CREATE TABLE lesson
(
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	course VARCHAR(45),
	teacher_id INT,
	FOREIGN KEY (teacher_id) REFERENCES teacher(id)
);
INSERT INTO lesson(course,teacher_id)
VALUES
("Знакомство с веб-технологиями",1),
("Знакомство с веб-технологиями",2),
("Знакомство с языками программирования",3),
("Базы данных и SQL",4),
("Нейронные сети", NULL); -- Учитель, который ведет данный предмет, временно отстутствует
SELECT * FROM lesson;

-- join связываем дву таблицы по id
SELECT * FROM teacher t
INNER JOIN lesson l
ON t.id = l.teacher_id
ORDER BY t.id;

-- left join 
-- объединили таблицы 
SELECT * FROM teacher t
LEFT JOIN lesson l
ON t.id = l.teacher_id
ORDER BY t.id;

-- right join 
SELECT * FROM teacher t
RIGHT JOIN lesson l
ON t.id = l.teacher_id
ORDER BY l.id;

-- cross join
SELECT * FROM teacher t
CROSS JOIN lesson l
#ON t.id = l.teacher_id
ORDER BY t.id;


-- ---------------------------------------------
DROP TABLE IF EXISTS products;
CREATE TABLE products
(
	product_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	category INT NULL,
	product_name VARCHAR(100) NOT NULL
);

-- Создание таблицы с категориями
DROP TABLE IF EXISTS categories;
CREATE TABLE categories
(
	category_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	category_name VARCHAR(100) NOT NULL
);

-- Добавление данных в таблицу с товарами
INSERT INTO products
(category, product_name)
VALUES
(1, 'Системный блок'),
(1, 'Монитор'),
(2, 'Холодильник'),
(2, 'Телевизор'),
(NULL, 'Операционная система');

-- Добавление данных в таблицу с категориями
INSERT INTO categories
(category_name)
VALUES
('Комплектующие компьютера'),
('Бытовая техника'),
('Мобильные устройства');

SELECT * FROM products;
SELECT * FROM categories;

-- full join
-- вывели вааще все
SELECT * FROM products p
LEFT JOIN categories c
ON p.category = c.category_id
UNION
SELECT * FROM products p
RIGHT JOIN categories c
ON p.category = c.category_id;

SELECT * FROM products p
LEFT JOIN categories c
ON p.category = c.category_id
UNION ALL
SELECT * FROM products p
RIGHT JOIN categories c
ON p.category = c.category_id;

SELECT COUNT(*)
FROM
(
SELECT * FROM products p
LEFT JOIN categories c
ON p.category = c.category_id
UNION
SELECT * FROM products p
RIGHT JOIN categories c
ON p.category = c.category_id
) AS list;




