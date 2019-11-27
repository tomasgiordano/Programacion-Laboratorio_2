--CREA LA BASE DE DATOS PARA EL EJERCICIO 61
create database Ejercicio61

--USA LA BASE DE DATOS CREADA 
use Ejercicio61

--CREA LA TABLA PERSONAS CON LOS CAMPOS CODIGO, DESCRIPCION Y CANTIDAD
CREATE TABLE Persona (
    ID int IDENTITY(1,1) PRIMARY KEY,
    Nombre varchar(50),
    Apellido varchar(50),
);

--INSERTA UN REGISTRO EN LA TABLA
insert into Persona (Nombre, Apellido) values ('Fulano', 'Menganitus')
insert into Persona (Nombre, Apellido) values ('Lulu', 'Support')

--ELIMINA UN REGISTRO DE LA TABLA
--delete from articulos where id = 1

--SELECCIONA TODOS LOS REGISTROS DE LA TABLA CON TODOS SUS CAMPOS
select * from Persona



