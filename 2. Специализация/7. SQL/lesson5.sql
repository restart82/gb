-- Оконные функции

use lesson4;

select * from categories;
select * from lesson;
select * from products;
select * from teacher;

select
	count(*) over (partition by teacher) as cnt
    , teacher_id
from lesson;