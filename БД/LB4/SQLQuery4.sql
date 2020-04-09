use master;
create database SAV_UNIVER
on primary
(name = N'SAV_UNIVER_mdf',
filename=N'D:\Уник\Лабораторные\БД\LB4\SAV_UNIVER.mdf',
size = 5Mb,
maxsize = 10Mb,
filegrowth = 1Mb),
(name = N'SAV_UNIVER_ndf',
filename=N'D:\Уник\Лабораторные\БД\LB4\SAV_UNIVER.ndf',
size = 5Mb,
maxsize = 10Mb,
filegrowth = 10%
),
filegroup G1
(name = N'SAV_UNIVER11_ndf',
filename = N'D:\Уник\Лабораторные\БД\LB4\SAV_UNIVER11.ndf',
size = 10Mb,
maxsize = 15Mb,
filegrowth = 1Mb),
(name = N'SAV_UNIVER12_ndf',
filename = N'D:\Уник\Лабораторные\БД\LB4\SAV_UNIVER12.ndf',
size = 2Mb,
maxsize = 5Mb,
filegrowth = 1Mb
),
filegroup G2
(name = N'SAV_UNIVER21_ndf',
filename = N'D:\Уник\Лабораторные\БД\LB4\SAV_UNIVER21.ndf',
size = 5Mb,
maxsize = 10Mb,
filegrowth = 1Mb),
(name = N'SAV_UNIVER22_ndf',
filename = N'D:\Уник\Лабораторные\БД\LB4\SAV_UNIVER22.ndf',
size = 2Mb,
maxsize = 5Mb,
filegrowth = 1Mb
)
log on
(name = N'SAV_UNIVER_log',
filename = N'D:\Уник\Лабораторные\БД\LB4\SAV_UNIVER.ldf',
size = 5MB,
maxsize = unlimited,
filegrowth = 1Mb)