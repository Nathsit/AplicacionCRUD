
-- CREACIÓN DE LA BASE DE DATOS
	-- Eliminamos base de datos 'NicoCreditos' si existe
		DROP DATABASE IF EXISTS NicoCreditos;
	-- Creamos base de datos 'NicoCreditos'
		CREATE DATABASE NicoCreditos;
	
-- CREACIÓN DE LAS TABLAS
	/* Borramos las tablas en caso tal de que ya existan. (Este paso es opcional ya que anteriormente ya se habia borrado la Base de datos NicoCreditos)
    */
		DROP TABLE IF EXISTS TipoCliente;
		DROP TABLE IF EXISTS Clientes;
		DROP TABLE IF EXISTS Secciones;
		DROP TABLE IF EXISTS Empleados;
		DROP TABLE IF EXISTS EmpleadosSecciones;
		DROP TABLE IF EXISTS Proveedores;
		DROP TABLE IF EXISTS Productos;


	-- Creación de tablas

	-- Se crea la primera tabla llamada tipoCliente
		CREATE TABLE TipoCliente (
			TipoClienteID INT PRIMARY KEY,
			Tipo VARCHAR(20)
		);

	-- Se insertan en la tabla tipoCliente los dos tipos que se van a manejar
		INSERT INTO TipoCliente (TipoClienteID, Tipo) VALUES (1, 'Persona Natural');
		INSERT INTO TipoCliente (TipoClienteID, Tipo) VALUES (2, 'Persona Jurídica');


	-- Se crea la tabla de clientes
		CREATE TABLE Clientes (
			ClienteID INT IDENTITY(1,1) PRIMARY KEY ,
			Nombre VARCHAR(100),
			Direccion VARCHAR(200),
			TipoClienteID INT,
			OtrosCampos VARCHAR(255),
			FOREIGN KEY (TipoClienteID) REFERENCES TipoCliente(TipoClienteID)
		);


	-- Crear la tabla "Secciones"
		CREATE TABLE Secciones (
			SeccionID INT PRIMARY KEY,
			Nombre VARCHAR(50)
		);

	-- Crear la tabla "Empleados"
		CREATE TABLE Empleados (
			EmpleadoID INT PRIMARY KEY,
			Nombre VARCHAR(100)
		);

	-- Crear la tabla intermedia "EmpleadosSecciones"
		CREATE TABLE EmpleadosSecciones (
			EmpleadoID INT,
			SeccionID INT,
			PRIMARY KEY (EmpleadoID, SeccionID),
			FOREIGN KEY (EmpleadoID) REFERENCES Empleados(EmpleadoID),
			FOREIGN KEY (SeccionID) REFERENCES Secciones(SeccionID)
		);

	-- Crear la tabla "Proveedores"
		CREATE TABLE Proveedores (
			ProveedorID INT PRIMARY KEY,
			Nombre VARCHAR(100),
			Direccion VARCHAR(200)
		);

	-- Crear la tabla "Productos"
		CREATE TABLE Productos (
			ProductoID INT IDENTITY(1,1) PRIMARY KEY,
			Nombre VARCHAR(100),
			Precio DECIMAL(10, 2),
			ProveedorID INT,
			FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID)
		);

