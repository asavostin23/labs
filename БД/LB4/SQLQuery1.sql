use master;
create database TMPSAV_UNIVER
on primary
(name = N'TMPSAV',
filename=N'D:\Уник\Лабораторные\БД\LB4\TMPSAV.mdf',
size = 10240Kb,
maxsize = unlimited,
filegrowth = 1024Kb)
log on
(name = N'TMPSAV_LOG',
filename = N'D:\Уник\Лабораторные\БД\LB4\TMPSAV_LOG.ldf',
size = 10240KB,
maxsize = 100Mb,
filegrowth = 10%)