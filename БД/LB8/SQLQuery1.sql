use SAV_UNIVER;

create view Преподаватель as
select TEACHER, TEACHER_NAME, GENDER, PULPIT
from TEACHER;

select * from Преподаватель;
drop view Преподаватель;

create view "Количество кафедр" as
select FACULTY.FACULTY_NAME, count(*)[Количество кафедр]
from FACULTY 
join PULPIT on FACULTY.FACULTY = PULPIT.FACULTY
group by
FACULTY.FACULTY_NAME

select * from [Количество кафедр];

create view [Аудитории] as
select AUDITORIUM[Код], AUDITORIUM_NAME[Название аудитории]
from AUDITORIUM
where AUDITORIUM_TYPE like 'ЛК%';

select * from [Аудитории]
select * from AUDITORIUM
/*
create view test as select * from AUDITORIUM where AUDITORIUM_TYPE like 'ЛК%'
select * from AUDITORIUM
select * from test
insert  test (AUDITORIUM, AUDITORIUM_NAME,  
AUDITORIUM_TYPE, AUDITORIUM_CAPACITY)   
values  ('206-2', '206-2','ЛБ-К', 15)
delete from AUDITORIUM where AUDITORIUM_NAME = '206-2'
drop view test
*/
create view [Лекционные аудитории] as
select AUDITORIUM[Код], AUDITORIUM_NAME[Название аудитории]
from AUDITORIUM
where AUDITORIUM_TYPE like 'ЛК%'
with check option
/*
create view test2 as select * from AUDITORIUM where AUDITORIUM_TYPE like 'ЛК%' with check option
select * from AUDITORIUM
select * from test
insert  test2 (AUDITORIUM, AUDITORIUM_NAME,  
AUDITORIUM_TYPE, AUDITORIUM_CAPACITY)   
values  ('206-2', '206-2','ЛБ-К', 15)
delete from AUDITORIUM where AUDITORIUM_NAME = '206-2'
drop view test2
*/
select * from [Лекционные аудитории]

create view Дисциплины as
select top 150
SUBJECT, SUBJECT_NAME, PULPIT from SUBJECT
order by SUBJECT_NAME asc

select * from Дисциплины

go
alter view [Количество кафедр]
with schemabinding
as
select FACULTY.FACULTY_NAME, count(*)[Количество кафедр]
from dbo.FACULTY 
join dbo.PULPIT on FACULTY.FACULTY = PULPIT.FACULTY
group by
FACULTY.FACULTY_NAME
go

alter table dbo.FACULTY drop column FACULTY_NAME
