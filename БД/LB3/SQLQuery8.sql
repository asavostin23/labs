use САВОСТИН_УНИВЕР;
create table STUDENT (
	"Номер зачетки" int primary key,
	Фамилия varchar(50) unique not null,
	"Номер группы" int,
	"Дата поступления" date,
	Пол char(1) check (Пол in ('М', 'Ж'))
  );