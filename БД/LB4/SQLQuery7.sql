use master;
create database �������_2
on primary
(name = N'�������2_1',
filename=N'D:\����\������������\��\LB4\�������2_1.mdf',
size = 10240Kb,
maxsize = unlimited,
filegrowth = 1024Kb),
filegroup G1
(name = N'�������2_2',
filename=N'D:\����\������������\��\LB4\�������2_2.ndf',
size = 10240Kb,
maxsize = unlimited,
filegrowth = 1024Kb)
log on
(name = N'TMPSAV_LOG',
filename = N'D:\����\������������\��\LB4\�������2_LOG.ldf',
size = 10240KB,
maxsize = 100Mb,
filegrowth = 10%)