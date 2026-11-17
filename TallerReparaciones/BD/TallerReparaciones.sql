-- Creacion de la base de datos del Taller de Reparaciones
create database TallerReparaciones
go

use TallerReparaciones
go

-- Tablas que no dependen de otras

create table Usuarios
(
   UsuarioID          int identity(1,1) primary key,
   Nombre             varchar(100) not null,
   CorreoElectronico  varchar(100),
   Telefono           varchar(20)
)
go

create table Tecnicos
(
   TecnicoID     int identity(1,1) primary key,
   Nombre        varchar(100) not null,
   Especialidad  varchar(100)
)
go

-- Tablas que dependen de otras (llaves foraneas)

create table Equipos
(
   EquipoID    int identity(1,1) primary key,
   TipoEquipo  varchar(50),
   Modelo      varchar(50),
   UsuarioID   int not null foreign key references Usuarios(UsuarioID)
)
go

create table Reparaciones
(
   ReparacionID    int identity(1,1) primary key,
   EquipoID        int not null foreign key references Equipos(EquipoID),
   FechaSolicitud  date,
   Estado          varchar(30)
)
go

create table Asignaciones
(
   AsignacionID     int identity(1,1) primary key,
   ReparacionID     int not null foreign key references Reparaciones(ReparacionID),
   TecnicoID        int not null foreign key references Tecnicos(TecnicoID),
   FechaAsignacion  date
)
go

create table DetallesReparacion
(
   DetalleID     int identity(1,1) primary key,
   ReparacionID  int not null foreign key references Reparaciones(ReparacionID),
   Descripcion   varchar(200),
   FechaInicio   date,
   FechaFin      date
)
go

-- Datos de prueba

insert into Usuarios (Nombre, CorreoElectronico, Telefono) values ('Ana Mora', 'ana@uh.com', '8888-1111')
insert into Usuarios (Nombre, CorreoElectronico, Telefono) values ('Carlos Rojas', 'carlos@uh.com', '8888-2222')

insert into Tecnicos (Nombre, Especialidad) values ('Luis Solano', 'Laptops')
insert into Tecnicos (Nombre, Especialidad) values ('Maria Vargas', 'Impresoras')
go

-- Consultas

select * from Usuarios
select * from Tecnicos
