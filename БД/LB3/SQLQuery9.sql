use ÑÀÂÎÑÒÈÍ_ÓÍÈÂÅÐ;
create table RESULTS (
	ID int primary key identity(1,1),
	STUDENT_NAME varchar(50) not null,
	MATH real not null check (MATH > 0 and MATH<=10),
	OOP real not null check (OOP > 0 and OOP<=10),
	AVER_VALUE as ((MATH + OOP) / 2)
)