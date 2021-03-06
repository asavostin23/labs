use SAV_UNIVER;

select PROFESSION.PROFESSION_NAME from PROFESSION where ((PROFESSION_NAME like '%����������%') or (PROFESSION_NAME like '%����������%'));
select PROFESSION.FACULTY from PROFESSION where ((PROFESSION_NAME like '%����������%') or (PROFESSION_NAME like '%����������%'));

select PULPIT.PULPIT_NAME, PROFESSION.PROFESSION_NAME, PULPIT.FACULTY from PULPIT,PROFESSION
where PULPIT.FACULTY in (select PROFESSION.FACULTY from PROFESSION where ((PROFESSION_NAME like '%����������%') or (PROFESSION_NAME like '%����������%'))); 

select PULPIT.PULPIT_NAME, PROFESSION.PROFESSION_NAME, PULPIT.FACULTY from PULPIT join PROFESSION
on PULPIT.FACULTY in (select PROFESSION.FACULTY from PROFESSION where ((PROFESSION_NAME like '%����������%') or (PROFESSION_NAME like '%����������%'))); 

select PULPIT.PULPIT_NAME, PROFESSION.PROFESSION_NAME, PULPIT.FACULTY from PULPIT join PROFESSION
on PULPIT.FACULTY=PROFESSION.FACULTY join FACULTY on ((PROFESSION_NAME like '%����������%') or (PROFESSION_NAME like '%����������%')); 

select AUDITORIUM,AUDITORIUM_CAPACITY,AUDITORIUM_TYPE from AUDITORIUM A1
where A1.AUDITORIUM_NAME = (select top(1) AUDITORIUM_NAME from AUDITORIUM A2 where A1.AUDITORIUM_TYPE = A2.AUDITORIUM_TYPE order by A2.AUDITORIUM_CAPACITY desc);

select FACULTY_NAME from FACULTY f
where not exists(select * from PULPIT p where f.FACULTY = p.FACULTY);

select top(1)
	(select avg(NOTE) from PROGRESS where PROGRESS.SUBJECT = '����')[����],
	(select avg(NOTE) from PROGRESS where PROGRESS.SUBJECT = '��')[��],
	(select avg(NOTE) from PROGRESS where PROGRESS.SUBJECT = '����')[����]
	from PROGRESS;

select s1.NAME, NOTE, SUBJECT from PROGRESS p1
join STUDENT s1 on p1.IDSTUDENT = s1.IDSTUDENT
where NOTE >= all(select NOTE from PROGRESS p2 where p2.SUBJECT = p1.SUBJECT)

select s1.NAME, NOTE, SUBJECT from PROGRESS p1
join STUDENT s1 on p1.IDSTUDENT = s1.IDSTUDENT
where NOTE > any(select NOTE from PROGRESS p2 where p2.SUBJECT = p1.SUBJECT)