CREATE DATABASE homeWork;
USE homeWork;

/* 1. Создайте функцию, которая принимает кол-во сек и формат их в кол-во дней часов.
      Пример: 123456 ->'1 days 10 hours 17 minutes 36 seconds'*/

DROP FUNCTION IF EXISTS parseSeconds;
DELIMITER $$
CREATE FUNCTION parseSeconds( inputSeconds BIGINT )
RETURNS VARCHAR(80) DETERMINISTIC
BEGIN
	-- var:
	DECLARE days INT; 
    DECLARE hours INT;
    DECLARE minutes INT;
    DECLARE seconds INT;
    DECLARE remainder INT;
    -- const:
    DECLARE secondsInOneDay INT;
    DECLARE secondsInOneHours INT;
    DECLARE secondsInOneMinute INT;
    SET secondsInOneDay = 60 * 60 * 24;
    SET secondsInOneHours = 60 * 60;
    SET secondsInOneMinute = 60;
    
    SET days = inputSeconds DIV secondsInOneDay;
    SET remainder = inputSeconds - days * secondsInOneDay;
    SET hours = remainder DIV secondsInOneHours;
    SET remainder = remainder - hours * secondsInOneHours;
    SET minutes = remainder DIV secondsInOneMinute;
    SET remainder = remainder - minutes * secondsInOneMinute;
    SET seconds = remainder;
    
	RETURN CONCAT(days, ' days ', hours, ' hours ', minutes, ' minutes ', seconds, ' seconds');
END; $$
DELIMITER ;
SELECT parseSeconds(123456);

-- 2. Выведите только четные числа от 1 до 10. Пример: 2,4,6,8,10
DROP PROCEDURE IF EXISTS PrintEvenNumbers;
DELIMITER $$
CREATE PROCEDURE PrintEvenNumbers(IN N INT)
BEGIN
	DECLARE counter INT;
	SET counter = 1;
	WHILE counter <= N DO
		IF counter % 2 = 0 THEN
			SELECT counter;
		END IF;
		SET counter = counter + 1;
	END WHILE;
END $$
DELIMITER ;
call PrintEvenNumbers(10);




