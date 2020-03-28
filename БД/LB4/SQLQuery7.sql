use master;
create database РЕКЛАМА_2
on primary
(name = N'РЕКЛАМА2_1',
filename=N'D:\Уник\Лабораторные\БД\LB4\Реклама2_1.mdf',
size = 10240Kb,
maxsize = unlimited,
filegrowth = 1024Kb),
filegroup G1
(name = N'РЕКЛАМА2_2',
filename=N'D:\Уник\Лабораторные\БД\LB4\Реклама2_2.ndf',
size = 10240Kb,
maxsize = unlimited,
filegrowth = 1024Kb)
log on
(name = N'TMPSAV_LOG',
filename = N'D:\Уник\Лабораторные\БД\LB4\РЕКЛАМА2_LOG.ldf',
size = 10240KB,
maxsize = 100Mb,
filegrowth = 10%)