use SAV_UNIVER;

declare @charVar char = 'М',
@varCharVar varchar(3) = 'ABC',
@datetimeVar datetime,
@timeVar time,
@intVar int,
@smallIntVar smallint,
@tinyIntVar tinyint,
@numericVar numeric(5,1)
set @timeVar = '23:15'
select @datetimeVar = (select top(1) BDAY from STUDENT)
select @smallIntVar = IDGROUP, @tinyIntVar = COURSE, @numericVar = YEAR_FIRST  from GROUPS
set @intVar = 1234
select @charVar[CHAR], @varCharVar[VARCHAR], @datetimeVar[DATETIME], @timeVar[TIME] /* ИЛИ */
print cast(@intVar as varchar(10))+' '+cast(@smallIntVar as varchar(10))+' '+cast(@tinyIntVar as varchar(10))+' '+cast(@numericVar as varchar(10))

declare @totalCapacity int = (select sum(AUDITORIUM_CAPACITY) from AUDITORIUM)
if @totalCapacity < 200
	begin
	print 'Общая вместимость: '+cast (@totalCapacity as VARCHAR(10))
	end
else
	begin
	declare @audtioriumCount int, @avgCapacity decimal(5,1), @lessThanNormal int, @lessThanNormalPercent int
	select @audtioriumCount = count(*), @avgCapacity = avg(AUDITORIUM_CAPACITY) from AUDITORIUM
	select @lessThanNormal = count(*) from AUDITORIUM where AUDITORIUM_CAPACITY < @avgCapacity
	set @lessThanNormalPercent = @lessThanNormal * 100 / @audtioriumCount
	select @audtioriumCount[Количество аудиторий],@avgCapacity[Средняя вместимость], @lessThanNormal[Аудиторий меньше среднего], @lessThanNormalPercent[Процент аудиторий меньше среднего]
	end

print '@@ROWCOUNT:'
print @@ROWCOUNT
print '@@VERSION:'
print @@VERSION
print '@@SPID:'
print @@SPID
print '@@ERROR:'
print @@ERROR
print '@@SERVERNAME:'
print @@SERVERNAME
print '@@TRANCOUNT:'
print @@TRANCOUNT
print '@@FETCH_STATUS:'
print @@FETCH_STATUS
print '@@NESTLEVEL:'
print @@NESTLEVEL

declare @z decimal(10,1), @x decimal(10,1), @t decimal(10,1)
set @t = 5
set @x = 3.3
if @t < @x
	begin
	set @z = sin(@t) * sin(@t)
	print 't < x'
	print 'z = sin('+cast(@t as varchar(11))+')^2 = '+cast(@z as varchar(11))
	end
else
	if  @t = @x
		begin
		print 't = x'
		set @z = 4 * (@t + @x)
		print 'z = 4('+cast(@t as varchar(11))+'+'+cast(@x as varchar(11))+') = '+cast(@z as varchar(11))
		end
	else
		begin
		print 't > x'
		set @z = 1 - exp(@x - 2)
		print 'z = 1 - e^('+cast(@x as varchar(11))+' - 2) = '+cast(@z as varchar(11))
		end

declare @name nvarchar(100) = 'Савостин Антон Дмитриевич', @result nvarchar(100)
set @result = LEFT(@name, CHARINDEX(' ',@name)+1) + '. '
set @name = RIGHT(@name, LEN(@name) - CHARINDEX(' ',@name))
set @result = @result + SUBSTRING(@name, CHARINDEX(' ',@name) + 1,1) + '. '
print @result

declare @FIO table (fio nvarchar(100),f nvarchar(100))
declare @num int = (select count(*) from STUDENT)
declare @i int = 0
declare @name nvarchar(100), @result nvarchar(100), @id int = 1000
while @i < @num
	begin
	set @name = (select NAME from STUDENT where IDSTUDENT = @id)
	set @result = LEFT(@name, CHARINDEX(' ',@name)+1) + '. '
	set @name = RIGHT(@name, LEN(@name) - CHARINDEX(' ',@name))
	set @result = @result + SUBSTRING(@name, CHARINDEX(' ',@name) + 1,1) + '. '
	insert @FIO(fio,f) values ((select NAME from STUDENT where IDSTUDENT = @id),@result)
	set @id = @id + 1
	set @i = @i + 1
	end
select fio[ФИО],f[Инициалы] from @FIO

select NAME[ФИО], BDAY[День рождения], YEAR(GETDATE()) - YEAR(BDAY)[Возраст] from STUDENT  where MONTH(BDAY)-MONTH(GETDATE()) = 1

declare @group int = 4 /* 6 */
declare @wd int = DATEPART(dw, (
select PDATE from STUDENT join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT where STUDENT.IDGROUP = @group and PROGRESS.SUBJECT = 'СУБД'
group by PDATE)
)
print
case @wd
	when 1 then 'Понедельник'
	when 2 then 'Вторник'
	when 3 then 'Среда'
	when 4 then 'Четверг'
	when 5 then 'Пятница'
	when 6 then 'Суббота'
	when 7 then 'Воскресенье'
end
	
select STUDENT.NAME[ФИО], 
(case 
	when PROGRESS.NOTE between 1 and 3 then 'Плохо'
	when  PROGRESS.NOTE = 4 then 'Главное, что сдал'
	when PROGRESS.NOTE between 5 and 6 then 'Более-менее'
	when PROGRESS.NOTE = 7 then 'Неплохо'
	when PROGRESS.NOTE = 8 then 'Хорошо'
	when PROGRESS.NOTE between 9 and 10 then 'Отлично'
end)[Оценка]
 from STUDENT
join GROUPS on STUDENT.IDGROUP = GROUPS.IDGROUP
join PROGRESS on STUDENT.IDSTUDENT = PROGRESS.IDSTUDENT
where GROUPS.FACULTY = 'ИДиП'
order by STUDENT.NAME

create table #nums(a int,b int,c int)
declare @i int = -2
while @i<=10
	begin
	insert #nums values(@i,@i*2,@i*3)
	set @i = @i + 1
	end
select * from #nums
drop table #nums

create table #nums(a int,b int,c int)
declare @i int = -2
if @i < 1 return
while @i<=10
	begin
	insert #nums values(@i,@i*2,@i*3)
	set @i = @i + 1
	end
select * from #nums
go
drop table #nums

begin TRY
insert AUDITORIUM values (null,null,null,null)
end TRY
begin CATCH
print ERROR_NUMBER()
print ERROR_MESSAGE()
print ERROR_LINE()
print ERROR_PROCEDURE()
print ERROR_SEVERITY()
print ERROR_STATE()
end CATCH