CREATE TABLE Cliente (
	Id int,
	Nombre varchar(50),
	Apellido varchar(50),
	DNI int,
	Telefono int,
	Email varchar(50),
	Direccion_Id int,
	TipoCliente_Id int,
	InstrumentoMusical_Id int,
	PRIMARY KEY(Id)
)
GO

CREATE PROCEDURE Cliente_SelectAll
AS
	SELECT 
		Id, 
		Nombre, 
		Apellido, 
		DNI, 
		Telefono, 
		Email, 
		Direccion_Id, 
		TipoCliente_Id, 
		InstrumentoMusical_Id
	FROM Cliente
GO

CREATE PROCEDURE Cliente_Select
	@Id int
AS
	SELECT 
		Id, 
		Nombre, 
		Apellido, 
		DNI, 
		Telefono, 
		Email, 
		Direccion_Id, 
		TipoCliente_Id, 
		InstrumentoMusical_Id
	FROM Cliente
	WHERE 
		Id=@Id
GO

CREATE PROCEDURE Cliente_Insert
	@Id int, 
	@Nombre varchar(50), 
	@Apellido varchar(50), 
	@DNI int, 
	@Telefono int, 
	@Email varchar(50), 
	@Direccion_Id int, 
	@TipoCliente_Id int, 
	@InstrumentoMusical_Id int
AS
	INSERT INTO Cliente (
		Id, 
		Nombre, 
		Apellido, 
		DNI, 
		Telefono, 
		Email, 
		Direccion_Id, 
		TipoCliente_Id, 
		InstrumentoMusical_Id
	) VALUES (
		@Id, 
		@Nombre, 
		@Apellido, 
		@DNI, 
		@Telefono, 
		@Email, 
		@Direccion_Id, 
		@TipoCliente_Id, 
		@InstrumentoMusical_Id
	)
GO

CREATE PROCEDURE Cliente_Update
	@Id int, 
	@Nombre varchar(50), 
	@Apellido varchar(50), 
	@DNI int, 
	@Telefono int, 
	@Email varchar(50), 
	@Direccion_Id int, 
	@TipoCliente_Id int, 
	@InstrumentoMusical_Id int
AS
	UPDATE Cliente SET 
		Nombre=@Nombre, 
		Apellido=@Apellido, 
		DNI=@DNI, 
		Telefono=@Telefono, 
		Email=@Email, 
		Direccion_Id=@Direccion_Id, 
		TipoCliente_Id=@TipoCliente_Id, 
		InstrumentoMusical_Id=@InstrumentoMusical_Id
	WHERE
		Id=@Id
GO

CREATE PROCEDURE Cliente_Delete
	@Id int
AS
	DELETE FROM Cliente
	WHERE 
		Id=@Id
GO

CREATE TABLE Direccion (
	Id int,
	Calle varchar(50),
	Numero smallint,
	PRIMARY KEY(Id)
)
GO

CREATE PROCEDURE Direccion_SelectAll
AS
	SELECT 
		Id, 
		Calle, 
		Numero
	FROM Direccion
GO

CREATE PROCEDURE Direccion_Select
	@Id int
AS
	SELECT 
		Id, 
		Calle, 
		Numero
	FROM Direccion
	WHERE 
		Id=@Id
GO

CREATE PROCEDURE Direccion_Insert
	@Id int, 
	@Calle varchar(50), 
	@Numero smallint
AS
	INSERT INTO Direccion (
		Id, 
		Calle, 
		Numero
	) VALUES (
		@Id, 
		@Calle, 
		@Numero
	)
GO

CREATE PROCEDURE Direccion_Update
	@Id int, 
	@Calle varchar(50), 
	@Numero smallint
AS
	UPDATE Direccion SET 
		Calle=@Calle, 
		Numero=@Numero
	WHERE
		Id=@Id
GO

CREATE PROCEDURE Direccion_Delete
	@Id int
AS
	DELETE FROM Direccion
	WHERE 
		Id=@Id
GO

CREATE TABLE TipoCliente (
	Id int,
	Descripcion varchar(50),
	PRIMARY KEY(Id)
)
GO

CREATE PROCEDURE TipoCliente_SelectAll
AS
	SELECT 
		Id, 
		Descripcion
	FROM TipoCliente
GO

CREATE PROCEDURE TipoCliente_Select
	@Id int
AS
	SELECT 
		Id, 
		Descripcion
	FROM TipoCliente
	WHERE 
		Id=@Id
GO

CREATE PROCEDURE TipoCliente_Insert
	@Id int, 
	@Descripcion varchar(50)
AS
	INSERT INTO TipoCliente (
		Id, 
		Descripcion
	) VALUES (
		@Id, 
		@Descripcion
	)
GO

CREATE PROCEDURE TipoCliente_Update
	@Id int, 
	@Descripcion varchar(50)
AS
	UPDATE TipoCliente SET 
		Descripcion=@Descripcion
	WHERE
		Id=@Id
GO

CREATE PROCEDURE TipoCliente_Delete
	@Id int
AS
	DELETE FROM TipoCliente
	WHERE 
		Id=@Id
GO

CREATE TABLE InstrumentoMusical (
	Id int,
	Nombre varchar(50),
	TipoInstrumento_Id int,
	Estado varchar(50),
	Antiguedad datetime,
	PRIMARY KEY(Id)
)
GO

CREATE PROCEDURE InstrumentoMusical_SelectAll
AS
	SELECT 
		Id, 
		Nombre, 
		TipoInstrumento_Id, 
		Estado, 
		Antiguedad
	FROM InstrumentoMusical
GO

CREATE PROCEDURE InstrumentoMusical_Select
	@Id int
AS
	SELECT 
		Id, 
		Nombre, 
		TipoInstrumento_Id, 
		Estado, 
		Antiguedad
	FROM InstrumentoMusical
	WHERE 
		Id=@Id
GO

CREATE PROCEDURE InstrumentoMusical_Insert
	@Id int, 
	@Nombre varchar(50), 
	@TipoInstrumento_Id int, 
	@Estado varchar(50), 
	@Antiguedad datetime
AS
	INSERT INTO InstrumentoMusical (
		Id, 
		Nombre, 
		TipoInstrumento_Id, 
		Estado, 
		Antiguedad
	) VALUES (
		@Id, 
		@Nombre, 
		@TipoInstrumento_Id, 
		@Estado, 
		@Antiguedad
	)
GO

CREATE PROCEDURE InstrumentoMusical_Update
	@Id int, 
	@Nombre varchar(50), 
	@TipoInstrumento_Id int, 
	@Estado varchar(50), 
	@Antiguedad datetime
AS
	UPDATE InstrumentoMusical SET 
		Nombre=@Nombre, 
		TipoInstrumento_Id=@TipoInstrumento_Id, 
		Estado=@Estado, 
		Antiguedad=@Antiguedad
	WHERE
		Id=@Id
GO

CREATE PROCEDURE InstrumentoMusical_Delete
	@Id int
AS
	DELETE FROM InstrumentoMusical
	WHERE 
		Id=@Id
GO

CREATE TABLE Servicio (
	Id int,
	Descripcion varchar(50),
	Costo int,
	Piezas_Id int,
	Garantia datetime,
	TipoServicio_Id int,
	Instrucciones_Id int,
	Fecha datetime,
	Estado_Id int,
	FechaProxRev int,
	Tecnico_Id int,
	InstrumentoMusical_Id int,
	PRIMARY KEY(Id)
)
GO

CREATE PROCEDURE Servicio_SelectAll
AS
	SELECT 
		Id, 
		Descripcion, 
		Costo, 
		Piezas_Id, 
		Garantia, 
		TipoServicio_Id, 
		Instrucciones_Id, 
		Fecha, 
		Estado_Id, 
		FechaProxRev, 
		Tecnico_Id, 
		InstrumentoMusical_Id
	FROM Servicio
GO

CREATE PROCEDURE Servicio_Select
	@Id int
AS
	SELECT 
		Id, 
		Descripcion, 
		Costo, 
		Piezas_Id, 
		Garantia, 
		TipoServicio_Id, 
		Instrucciones_Id, 
		Fecha, 
		Estado_Id, 
		FechaProxRev, 
		Tecnico_Id, 
		InstrumentoMusical_Id
	FROM Servicio
	WHERE 
		Id=@Id
GO

CREATE PROCEDURE Servicio_Insert
	@Id int, 
	@Descripcion varchar(50), 
	@Costo int, 
	@Piezas_Id int, 
	@Garantia datetime, 
	@TipoServicio_Id int, 
	@Instrucciones_Id int, 
	@Fecha datetime, 
	@Estado_Id int, 
	@FechaProxRev int, 
	@Tecnico_Id int, 
	@InstrumentoMusical_Id int
AS
	INSERT INTO Servicio (
		Id, 
		Descripcion, 
		Costo, 
		Piezas_Id, 
		Garantia, 
		TipoServicio_Id, 
		Instrucciones_Id, 
		Fecha, 
		Estado_Id, 
		FechaProxRev, 
		Tecnico_Id, 
		InstrumentoMusical_Id
	) VALUES (
		@Id, 
		@Descripcion, 
		@Costo, 
		@Piezas_Id, 
		@Garantia, 
		@TipoServicio_Id, 
		@Instrucciones_Id, 
		@Fecha, 
		@Estado_Id, 
		@FechaProxRev, 
		@Tecnico_Id, 
		@InstrumentoMusical_Id
	)
GO

CREATE PROCEDURE Servicio_Update
	@Id int, 
	@Descripcion varchar(50), 
	@Costo int, 
	@Piezas_Id int, 
	@Garantia datetime, 
	@TipoServicio_Id int, 
	@Instrucciones_Id int, 
	@Fecha datetime, 
	@Estado_Id int, 
	@FechaProxRev int, 
	@Tecnico_Id int, 
	@InstrumentoMusical_Id int
AS
	UPDATE Servicio SET 
		Descripcion=@Descripcion, 
		Costo=@Costo, 
		Piezas_Id=@Piezas_Id, 
		Garantia=@Garantia, 
		TipoServicio_Id=@TipoServicio_Id, 
		Instrucciones_Id=@Instrucciones_Id, 
		Fecha=@Fecha, 
		Estado_Id=@Estado_Id, 
		FechaProxRev=@FechaProxRev, 
		Tecnico_Id=@Tecnico_Id, 
		InstrumentoMusical_Id=@InstrumentoMusical_Id
	WHERE
		Id=@Id
GO

CREATE PROCEDURE Servicio_Delete
	@Id int
AS
	DELETE FROM Servicio
	WHERE 
		Id=@Id
GO

CREATE TABLE Piezas (
	Id int,
	Descripcion varchar(50),
	Costo int,
	PRIMARY KEY(Id)
)
GO

CREATE PROCEDURE Piezas_SelectAll
AS
	SELECT 
		Id, 
		Descripcion, 
		Costo
	FROM Piezas
GO

CREATE PROCEDURE Piezas_Select
	@Id int
AS
	SELECT 
		Id, 
		Descripcion, 
		Costo
	FROM Piezas
	WHERE 
		Id=@Id
GO

CREATE PROCEDURE Piezas_Insert
	@Id int, 
	@Descripcion varchar(50), 
	@Costo int
AS
	INSERT INTO Piezas (
		Id, 
		Descripcion, 
		Costo
	) VALUES (
		@Id, 
		@Descripcion, 
		@Costo
	)
GO

CREATE PROCEDURE Piezas_Update
	@Id int, 
	@Descripcion varchar(50), 
	@Costo int
AS
	UPDATE Piezas SET 
		Descripcion=@Descripcion, 
		Costo=@Costo
	WHERE
		Id=@Id
GO

CREATE PROCEDURE Piezas_Delete
	@Id int
AS
	DELETE FROM Piezas
	WHERE 
		Id=@Id
GO

CREATE TABLE Estado (
	Id int,
	Descripcion varchar(50),
	PRIMARY KEY(Id)
)
GO

CREATE PROCEDURE Estado_SelectAll
AS
	SELECT 
		Id, 
		Descripcion
	FROM Estado
GO

CREATE PROCEDURE Estado_Select
	@Id int
AS
	SELECT 
		Id, 
		Descripcion
	FROM Estado
	WHERE 
		Id=@Id
GO

CREATE PROCEDURE Estado_Insert
	@Id int, 
	@Descripcion varchar(50)
AS
	INSERT INTO Estado (
		Id, 
		Descripcion
	) VALUES (
		@Id, 
		@Descripcion
	)
GO

CREATE PROCEDURE Estado_Update
	@Id int, 
	@Descripcion varchar(50)
AS
	UPDATE Estado SET 
		Descripcion=@Descripcion
	WHERE
		Id=@Id
GO

CREATE PROCEDURE Estado_Delete
	@Id int
AS
	DELETE FROM Estado
	WHERE 
		Id=@Id
GO

CREATE TABLE TipoServicio (
	Id int,
	Descripcion varchar(50),
	PRIMARY KEY(Id)
)
GO

CREATE PROCEDURE TipoServicio_SelectAll
AS
	SELECT 
		Id, 
		Descripcion
	FROM TipoServicio
GO

CREATE PROCEDURE TipoServicio_Select
	@Id int
AS
	SELECT 
		Id, 
		Descripcion
	FROM TipoServicio
	WHERE 
		Id=@Id
GO

CREATE PROCEDURE TipoServicio_Insert
	@Id int, 
	@Descripcion varchar(50)
AS
	INSERT INTO TipoServicio (
		Id, 
		Descripcion
	) VALUES (
		@Id, 
		@Descripcion
	)
GO

CREATE PROCEDURE TipoServicio_Update
	@Id int, 
	@Descripcion varchar(50)
AS
	UPDATE TipoServicio SET 
		Descripcion=@Descripcion
	WHERE
		Id=@Id
GO

CREATE PROCEDURE TipoServicio_Delete
	@Id int
AS
	DELETE FROM TipoServicio
	WHERE 
		Id=@Id
GO

CREATE TABLE Tecnico (
	Id int,
	Nombre varchar(50),
	Apellido varchar(50),
	DNI int,
	Descripcion varchar(50),
	PRIMARY KEY(Id)
)
GO

CREATE PROCEDURE Tecnico_SelectAll
AS
	SELECT 
		Id, 
		Nombre, 
		Apellido, 
		DNI, 
		Descripcion
	FROM Tecnico
GO

CREATE PROCEDURE Tecnico_Select
	@Id int
AS
	SELECT 
		Id, 
		Nombre, 
		Apellido, 
		DNI, 
		Descripcion
	FROM Tecnico
	WHERE 
		Id=@Id
GO

CREATE PROCEDURE Tecnico_Insert
	@Id int, 
	@Nombre varchar(50), 
	@Apellido varchar(50), 
	@DNI int, 
	@Descripcion varchar(50)
AS
	INSERT INTO Tecnico (
		Id, 
		Nombre, 
		Apellido, 
		DNI, 
		Descripcion
	) VALUES (
		@Id, 
		@Nombre, 
		@Apellido, 
		@DNI, 
		@Descripcion
	)
GO

CREATE PROCEDURE Tecnico_Update
	@Id int, 
	@Nombre varchar(50), 
	@Apellido varchar(50), 
	@DNI int, 
	@Descripcion varchar(50)
AS
	UPDATE Tecnico SET 
		Nombre=@Nombre, 
		Apellido=@Apellido, 
		DNI=@DNI, 
		Descripcion=@Descripcion
	WHERE
		Id=@Id
GO

CREATE PROCEDURE Tecnico_Delete
	@Id int
AS
	DELETE FROM Tecnico
	WHERE 
		Id=@Id
GO

CREATE TABLE Instrucciones (
	Id int,
	Descripcion varchar(100),
	PRIMARY KEY(Id)
)
GO

CREATE PROCEDURE Instrucciones_SelectAll
AS
	SELECT 
		Id, 
		Descripcion
	FROM Instrucciones
GO

CREATE PROCEDURE Instrucciones_Select
	@Id int
AS
	SELECT 
		Id, 
		Descripcion
	FROM Instrucciones
	WHERE 
		Id=@Id
GO

CREATE PROCEDURE Instrucciones_Insert
	@Id int, 
	@Descripcion varchar(100)
AS
	INSERT INTO Instrucciones (
		Id, 
		Descripcion
	) VALUES (
		@Id, 
		@Descripcion
	)
GO

CREATE PROCEDURE Instrucciones_Update
	@Id int, 
	@Descripcion varchar(100)
AS
	UPDATE Instrucciones SET 
		Descripcion=@Descripcion
	WHERE
		Id=@Id
GO

CREATE PROCEDURE Instrucciones_Delete
	@Id int
AS
	DELETE FROM Instrucciones
	WHERE 
		Id=@Id
GO

CREATE TABLE Factura (
	Numero int,
	Fecha datetime,
	Servicio_Id int,
	Sucursal_Id int,
	Monto int,
	PRIMARY KEY(Numero)
)
GO

CREATE PROCEDURE Factura_SelectAll
AS
	SELECT 
		Numero, 
		Fecha, 
		Servicio_Id, 
		Sucursal_Id, 
		Monto
	FROM Factura
GO

CREATE PROCEDURE Factura_Select
	@Numero int
AS
	SELECT 
		Numero, 
		Fecha, 
		Servicio_Id, 
		Sucursal_Id, 
		Monto
	FROM Factura
	WHERE 
		Numero=@Numero
GO

CREATE PROCEDURE Factura_Insert
	@Numero int, 
	@Fecha datetime, 
	@Servicio_Id int, 
	@Sucursal_Id int, 
	@Monto int
AS
	INSERT INTO Factura (
		Numero, 
		Fecha, 
		Servicio_Id, 
		Sucursal_Id, 
		Monto
	) VALUES (
		@Numero, 
		@Fecha, 
		@Servicio_Id, 
		@Sucursal_Id, 
		@Monto
	)
GO

CREATE PROCEDURE Factura_Update
	@Numero int, 
	@Fecha datetime, 
	@Servicio_Id int, 
	@Sucursal_Id int, 
	@Monto int
AS
	UPDATE Factura SET 
		Fecha=@Fecha, 
		Servicio_Id=@Servicio_Id, 
		Sucursal_Id=@Sucursal_Id, 
		Monto=@Monto
	WHERE
		Numero=@Numero
GO

CREATE PROCEDURE Factura_Delete
	@Numero int
AS
	DELETE FROM Factura
	WHERE 
		Numero=@Numero
GO

CREATE TABLE Sucursal (
	Id int,
	Zona varchar(50),
	Descripcion varchar(50),
	PRIMARY KEY(Id)
)
GO

CREATE PROCEDURE Sucursal_SelectAll
AS
	SELECT 
		Id, 
		Zona, 
		Descripcion
	FROM Sucursal
GO

CREATE PROCEDURE Sucursal_Select
	@Id int
AS
	SELECT 
		Id, 
		Zona, 
		Descripcion
	FROM Sucursal
	WHERE 
		Id=@Id
GO

CREATE PROCEDURE Sucursal_Insert
	@Id int, 
	@Zona varchar(50), 
	@Descripcion varchar(50)
AS
	INSERT INTO Sucursal (
		Id, 
		Zona, 
		Descripcion
	) VALUES (
		@Id, 
		@Zona, 
		@Descripcion
	)
GO

CREATE PROCEDURE Sucursal_Update
	@Id int, 
	@Zona varchar(50), 
	@Descripcion varchar(50)
AS
	UPDATE Sucursal SET 
		Zona=@Zona, 
		Descripcion=@Descripcion
	WHERE
		Id=@Id
GO

CREATE PROCEDURE Sucursal_Delete
	@Id int
AS
	DELETE FROM Sucursal
	WHERE 
		Id=@Id
GO

CREATE TABLE TipoInstrumento (
	Id int,
	Descripcion varchar(50),
	PRIMARY KEY(Id)
)
GO

CREATE PROCEDURE TipoInstrumento_SelectAll
AS
	SELECT 
		Id, 
		Descripcion
	FROM TipoInstrumento
GO

CREATE PROCEDURE TipoInstrumento_Select
	@Id int
AS
	SELECT 
		Id, 
		Descripcion
	FROM TipoInstrumento
	WHERE 
		Id=@Id
GO

CREATE PROCEDURE TipoInstrumento_Insert
	@Id int, 
	@Descripcion varchar(50)
AS
	INSERT INTO TipoInstrumento (
		Id, 
		Descripcion
	) VALUES (
		@Id, 
		@Descripcion
	)
GO

CREATE PROCEDURE TipoInstrumento_Update
	@Id int, 
	@Descripcion varchar(50)
AS
	UPDATE TipoInstrumento SET 
		Descripcion=@Descripcion
	WHERE
		Id=@Id
GO

CREATE PROCEDURE TipoInstrumento_Delete
	@Id int
AS
	DELETE FROM TipoInstrumento
	WHERE 
		Id=@Id
GO


ALTER TABLE Cliente
  ADD FOREIGN KEY (Direccion_Id)
  REFERENCES Direccion (Id)
GO


ALTER TABLE Cliente
  ADD FOREIGN KEY (TipoCliente_Id)
  REFERENCES TipoCliente (Id)
GO


ALTER TABLE Cliente
  ADD FOREIGN KEY (InstrumentoMusical_Id)
  REFERENCES InstrumentoMusical (Id)
GO


ALTER TABLE InstrumentoMusical
  ADD FOREIGN KEY (TipoInstrumento_Id)
  REFERENCES TipoInstrumento (Id)
GO


ALTER TABLE Servicio
  ADD FOREIGN KEY (Piezas_Id)
  REFERENCES Piezas (Id)
GO


ALTER TABLE Servicio
  ADD FOREIGN KEY (TipoServicio_Id)
  REFERENCES TipoServicio (Id)
GO


ALTER TABLE Servicio
  ADD FOREIGN KEY (Instrucciones_Id)
  REFERENCES Instrucciones (Id)
GO


ALTER TABLE Servicio
  ADD FOREIGN KEY (Estado_Id)
  REFERENCES Estado (Id)
GO


ALTER TABLE Servicio
  ADD FOREIGN KEY (Tecnico_Id)
  REFERENCES Tecnico (Id)
GO


ALTER TABLE Servicio
  ADD FOREIGN KEY (InstrumentoMusical_Id)
  REFERENCES InstrumentoMusical (Id)
GO


ALTER TABLE Factura
  ADD FOREIGN KEY (Servicio_Id)
  REFERENCES Servicio (Id)
GO


ALTER TABLE Factura
  ADD FOREIGN KEY (Sucursal_Id)
  REFERENCES Sucursal (Id)
GO

