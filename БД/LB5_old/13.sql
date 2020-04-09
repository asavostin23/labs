use SAV_UNIVER;
drop table #TEMPSTUDENTFIODATE;
/*
create table #TEMPSTUDENTFIODATE(
NAME nvarchar(100),
BDAY date
);
go
*/
select NAME, BDAY into #TEMPSTUDENTFIODATE from STUDENT;

select * from #TEMPSTUDENTFIODATE;
