CREATE DATABASE dbSMTutorial

GO
USE dbSMTutorial

GO
CREATE TABLE tblPersona
(
	cedula VARCHAR(20) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	fechaNacimiento DATE NOT NULL,
	edad INT NOT NULL,
	direccion VARCHAR(50) NOT NULL,
	CONSTRAINT pk_persona PRIMARY KEY(cedula)
)

/* Procedimiento almacenado (consultar y eliminar) */
GO
CREATE PROCEDURE spPersonaSE (
 @operacion VARCHAR(1), 
 @cedula VARCHAR(20)
)
AS
BEGIN
IF @operacion = 'S'
SELECT * FROM tblPersona WHERE cedula = @cedula
ELSE
IF @operacion = 'E'
DELETE FROM tblPersona WHERE cedula = @cedula
ELSE
SELECT * FROM tblPersona
END

/* Procedimiento para insertar y actualizar */
GO
CREATE PROCEDURE spPersonaIA (
 @operacion varchar(1),
 @cedula varchar(20),
 @nombre varchar(50),
 @apellido varchar(50),
 @fechaNacimiento date,
 @edad int,
 @direccion varchar(50)
 )
 AS
 BEGIN
 IF @operacion = 'I'
 INSERT INTO tblPersona VALUES(@cedula,@nombre,@apellido,@fechaNacimiento,@edad,@direccion)
 ELSE
 IF @operacion = 'A'
 UPDATE tblPersona SET nombre=@nombre, apellido=@apellido, fechaNacimiento=@fechaNacimiento, 
 edad=@edad, direccion=@direccion WHERE cedula=@cedula
 END