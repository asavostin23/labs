use SAV_UNIVER;

create view ������������� as
select TEACHER, TEACHER_NAME, GENDER, PULPIT
from TEACHER;

select * from �������������;
drop view �������������;

create view "���������� ������" as
select FACULTY.FACULTY_NAME, count(*)[���������� ������]
from FACULTY 
join PULPIT on FACULTY.FACULTY = PULPIT.FACULTY
group by
FACULTY.FACULTY_NAME

select * from [���������� ������];

create view [���������] as
select AUDITORIUM[���], AUDITORIUM_NAME[�������� ���������]
from AUDITORIUM
where AUDITORIUM_TYPE like '��%';

select * from [���������]
select * from AUDITORIUM
/*
create view test as select * from AUDITORIUM where AUDITORIUM_TYPE like '��%'
select * from AUDITORIUM
select * from test
insert  test (AUDITORIUM, AUDITORIUM_NAME,  
AUDITORIUM_TYPE, AUDITORIUM_CAPACITY)   
values  ('206-2', '206-2','��-�', 15)
delete from AUDITORIUM where AUDITORIUM_NAME = '206-2'
drop view test
*/
create view [���������� ���������] as
select AUDITORIUM[���], AUDITORIUM_NAME[�������� ���������]
from AUDITORIUM
where AUDITORIUM_TYPE like '��%'
with check option
/*
create view test2 as select * from AUDITORIUM where AUDITORIUM_TYPE like '��%' with check option
select * from AUDITORIUM
select * from test
insert  test2 (AUDITORIUM, AUDITORIUM_NAME,  
AUDITORIUM_TYPE, AUDITORIUM_CAPACITY)   
values  ('206-2', '206-2','��-�', 15)
delete from AUDITORIUM where AUDITORIUM_NAME = '206-2'
drop view test2
*/
select * from [���������� ���������]

create view ���������� as
select top 150
SUBJECT, SUBJECT_NAME, PULPIT from SUBJECT
order by SUBJECT_NAME asc

select * from ����������

go
alter view [���������� ������]
with schemabinding
as
select FACULTY.FACULTY_NAME, count(*)[���������� ������]
from dbo.FACULTY 
join dbo.PULPIT on FACULTY.FACULTY = PULPIT.FACULTY
group by
FACULTY.FACULTY_NAME
go

alter table dbo.FACULTY drop column FACULTY_NAME
