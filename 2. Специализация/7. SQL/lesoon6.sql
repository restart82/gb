-- создание процедуры

use sakila;

drop procedure if exists GetSome;
DELIMITER $$
CREATE PROCEDURE GetSome()
BEGIN
	SELECT
		customer_id,
		concat(first_name,' ',last_name) as name,
		email,
		active,
		last_update
	FROM
		customer
	ORDER BY name;
END$$
DELIMITER ;

call GetSome();


-- 0 1 [n(3) = n(2) + n(1)]

drop procedure if exists fib;
delimiter $$
create procedure fib(in n int, out res int) # вход / выход функции
begin
	DECLARE i INT default 0;
	DECLARE fib1 INT default 1;
	DECLARE fib2 INT default 1;
	if (n < 0) then
		select 'отрицательный индекс нельзя';
	elseif (n = 0) then
		set res = 0;
	else
		while i < n - 2 do
			set res = fib1 + fib2;
			set fib1 = fib2;
			set fib2 = res;
			set i = i +1;
		end while;
		set res = fib2;
	end if;
end $$
delimiter ;

call fib(20, @result);
select @result;
-- ------------

DELIMITER //
CREATE PROCEDURE CalculateFibonacci(IN n INT, OUT result INT)
BEGIN
	DECLARE a INT DEFAULT 0;
	DECLARE b INT DEFAULT 1;
	DECLARE i INT DEFAULT 2;

	IF n = 0 THEN
		SET result = 0;
	ELSEIF n = 1 THEN
		SET result = 1;
	ELSE
		WHILE i <= n DO
			SET result = a + b;
			SET a = b;
			SET b = result;
			SET i = i + 1;
		END WHILE;
	END IF;
END //
DELIMITER ;

CALL CalculateFibonacci(10, @fibonacciResult);
SELECT @fibonacciResult;

/*
Создайте хранимую функцию hello(), которая будет возвращать приветствие,
в зависимости от текущего времени суток.
С 6:00 до 12:00 функция должна возвращать фразу "Доброе утро",
с 12:00 до 18:00 функция должна возвращать фразу "Добрый день",
с 18:00 до 00:00 — "Добрый вечер", с 00:00 до 6:00 — "Доброй ночи".
*/

drop function if exists hello;
delimiter $$
create function hello() returns varchar(255) deterministic
begin
	declare current_hour int;
	DECLARE greeting VARCHAR(255);
	SET current_hour = HOUR(NOW());
	if current_hour >= 6 and current_hour < 12 then
		set greeting = 'Доброе утро';
	elseif current_hour >= 12 and current_hour < 18 then
		set greeting = 'Доброе день';
	elseif current_hour >= 18 and current_hour < 24 then
		set greeting = 'Добрый вечер';
	else
		set greeting = 'Доброй ночи';
	end if;
	return greeting;
end $$
delimiter ;

select hello();

-- --------------------------------
CREATE TABLE bankaccounts(accountno varchar(20) PRIMARY KEY NOT NULL, funds decimal(8,2));
-- Добавьте информацию о двух счетах с именами ACC1 и ACC2 с начальным балансом средств в размере 1000 долларов США каждый.
INSERT INTO bankaccounts VALUES("ACC1", 1000);
INSERT INTO bankaccounts VALUES("ACC2", 1000);
-- Изменим баланс на аккаунтах
START TRANSACTION;
UPDATE bankaccounts SET funds=funds-100 WHERE accountno='ACC1';
UPDATE bankaccounts SET funds=funds+100 WHERE accountno='ACC2';
COMMIT;

-- цикл while-------------
DELIMITER $$
CREATE PROCEDURE PrintNumbersFromNTo1(IN N INT)
BEGIN
	DECLARE counter INT;
	SET counter = N;
	WHILE counter >= 1 DO
		SELECT counter;
		SET counter = counter - 1;
	END WHILE;
END $$
DELIMITER ;

call PrintNumbersFromNTo1(10);


drop procedure if exists TableNumbersFromNTo1;
DELIMITER $$
CREATE PROCEDURE TableNumbersFromNTo1(IN N INT)
BEGIN
	DECLARE counter INT;
	SET counter = N;
	CREATE temporary table if not exists num_list (num int);
	WHILE counter >= 1 DO
		insert into num_list (num)
		values (counter);
		SET counter = counter - 1;
	END WHILE;
END $$
DELIMITER ;

call TableNumbersFromNTo1(2);
select * from num_list;
DROP TEMPORARY TABLE IF EXISTS temp_numbers;