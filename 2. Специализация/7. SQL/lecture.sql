create database MyFirstDB;

use MyFirstDB;

-- LECTURE3
-- --------------------------------
create table products
(id int auto_increment not null primary key,
ProductName varchar(45) not null,
Manufacturer varchar(45) not null,
ProductCount int unsigned default(0),
Price int UNSIGNED);

select * from products;

alter table products
rename column ProductNane to ProductName;

insert into products
(ProductName, Manufacturer, ProductCount, Price)
values
('iPhone X', 'Apple', 3, 76000),
('iPhone 8', 'Apple', 2, 51000),
('iPhone 7', 'Apple', 5, 32000),
('Galaxy S9', 'Sunsung', 2, 56000),
('Galaxy S8', 'Sunsung', 1, 46000),
('Honor 10', 'Huawei', 5, 28000),
('Nokia 8', 'HMD Global', 6, 38000);

select * from products
order by price desc;

-- count
select count(*) as sum
from products;

-- top
select * from products
limit 2, 5;

-- sum
select sum(price) from products;

-- min /
select min(price) from products
WHERE Manufacturer = 'Apple';

select min(price), max(price), avg(price) from products
where Manufacturer = 'Sunsung';


select Manufacturer, Price, ProductCount from products
where Price > 40000
group by Manufacturer;

-- LECTURE5
-- --------------------------------

CREATE VIEW CopuProducts AS
SELECT Price, ProductCount, Manufacturer
FROM products
WHERE Manufacturer = 'Apple';

select * from CopuProducts;

-- drop view CopuProducts;

-- drop table products;

alter view CopuProducts as
select Price, ProductCount, Manufacturer, ProductName
from products
WHERE Manufacturer = 'Apple';











