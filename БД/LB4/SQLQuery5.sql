use SAV_UNIVER;
/*
create table FACULTY(
FACULTY char(10) primary key not null,
FACULTY_NAME varchar(50) default '???'
);
create table AUDITORIUM_TYPE(
AUDITORIUM_TYPE char(10) primary key,
AUDITORIUM_TYPENAME varchar(30)
);
create table PROFESSION(
PROFESSION char(20) primary key not null,
FACULTY char(10) foreign key references FACULTY(FACULTY) not null,
PROFESSION_NAME varchar(100),
QUALIFICATION varchar(50)
);
create table PULPIT(
PULPIT char(20) primary key,
PULPIT_NAME varchar(100),
FACULTY char(10) foreign key references FACULTY(FACULTY) not null
) on G1;
create table TEACHER(
TEACHER char(10) primary key,
TEACHER_NAME varchar(100),
GENDER char(1) check(GENDER in ('ì','æ')),
PULPIT char(20) foreign key references PULPIT(PULPIT) not null
) on G1;
create table SUBJECT(
SUBJECT char(10) primary key,
SUBJECT_NAME varchar(100) unique,
PULPIT char(20) foreign key references PULPIT(PULPIT) not null
) on G1;
create table AUDITORIUM (
AUDITORIUM char(20) primary key,
AUDITORIUM_TYPE char(10) foreign key references AUDITORIUM_TYPE(AUDITORIUM_TYPE) not null,
AUDITORIUM_CAPACITY int default 1 check (AUDITORIUM_CAPACITY between 1 AND 300),
AUDITORIUM_NAME varchar(50)
) on G2;
*/
create table GROUPS(
IDGROUP int primary key identity(1,1),
FACULTY char(10) foreign key references FACULTY(FACULTY),
PROFESSION char(20) foreign key references PROFESSION(PROFESSION) not null,
YEAR_FIRST smallint check (YEAR_FIRST < YEAR(GETDATE()) + 2),
COURSE as ( YEAR(GETDATE()) - YEAR_FIRST )
) on G1;
create table STUDENT(
IDSTUDENT int primary key identity(1000,1),
IDGROUP int foreign key references GROUPS(IDGROUP) not null,
NAME nvarchar(100),
BDAY date,
STAMP timestamp,
INFO xml default null,
FOTO varbinary(max) default null
) on G1;