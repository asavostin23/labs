use ��������_������;
create table STUDENT (
	"����� �������" int primary key,
	������� varchar(50) unique not null,
	"����� ������" int,
	"���� �����������" date,
	��� char(1) check (��� in ('�', '�'))
  );