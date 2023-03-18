create database Practica_Nominas

use Practica_Nominas

create table Usuario(
ID_Usuarios int identity (1,1) PRIMARY KEY NOT NULL,
Nombre varchar (20),
Contraseña varchar (20),
Consultar bit,
Registrar bit,
Su bit, 
)

create table Empleados (
ID_Cliente int identity (1,1) PRIMARY KEY NOT NULL,
Nombre varchar (50),
Cedula varchar (50),
Fecha_Nacimiento date,
Cargo varchar (50),
Sueldo_bruto varchar (500),
ARS varchar (50), 
AFP varchar (50),
Vivienda varchar(50),
Sueldo_Neto varchar (500),
)

insert into Usuario(Nombre, Contraseña, Consultar, Registrar, Su)
values('Jose','1234','1','1','1')

SELECT * FROM Usuario
SELECT * FROM Empleados

Drop table Usuarios
Drop table Empleados