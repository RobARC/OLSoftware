CREATE DATABASE OLSoftware;

CREATE TABLE Usuarios (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Username VARCHAR(100),
	Password VARCHAR(100)
);

CREATE TABLE Aspirante (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
	Apellido VARCHAR(100),
    Telefono VARCHAR(100),
	Email VARCHAR(100),
    UsuarioId INT,
    FechaActualizacion DATETIME,
	CONSTRAINT Aspirante_UsuarioId FOREIGN KEY (UsuarioId)
	REFERENCES Usuarios(Id),
);



CREATE TABLE NivelPrueba (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nivel VARCHAR(100) NOT NULL,
	UsuarioId INT,
	FechaActualizacion DATETIME,
	CONSTRAINT NivelPrueba_UsuarioId FOREIGN KEY(UsuarioId)
	REFERENCES Usuarios(Id)
);

CREATE TABLE TipoPrueba (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Tipo VARCHAR(100) NOT NULL,
	UsuarioId INT,
	FechaActualizacion DATETIME,
	CONSTRAINT TipoPrueba_UsuarioId FOREIGN KEY(UsuarioId)
	REFERENCES Usuarios(Id)
);

CREATE TABLE EstadoPrueba(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Estado VARCHAR(100) NOT NULL,
	UsuarioId INT,
	FechaActualizacion DATETIME,
	CONSTRAINT EstadoPrueba_UsuarioId FOREIGN KEY(UsuarioId)
	REFERENCES Usuarios(Id)
);

CREATE TABLE PruebaSeleccion (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion VARCHAR(255),
	AspiranteId INT NOT NULL,
    FechaInicio DATETIME NOT NULL,
	FechaFin DATETIME,
	LenguajeProgramacion VARCHAR(50),
    CantidadPreguntas INT,
	TipoPruebaId INT,
	NivelPruebaId INT,
	EstadoPruebaId INT,
	Calificacion DECIMAL(10,2),
	UsuarioId INT,
	FechaActualizacion DATETIME,
	CONSTRAINT PruebaSeleccion_AspiranteId FOREIGN KEY (AspiranteId) REFERENCES Aspirante(Id),
	CONSTRAINT PruebaSeleccion_UsuarioId FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id),
    CONSTRAINT PruebaSeleccion_TipoPruebaId FOREIGN KEY (TipoPruebaId) REFERENCES TipoPrueba(Id),
	CONSTRAINT PruebaSeleccion_NivelPruebaId FOREIGN KEY (NivelPruebaId) REFERENCES NivelPrueba(Id),
	CONSTRAINT PruebaSeleccion_EstadoPruebaId FOREIGN KEY (EstadoPruebaId) REFERENCES EstadoPrueba(Id),
);


CREATE TABLE Preguntas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Pregunta  NVARCHAR(500) NOT NULL,
    Respuesta NVARCHAR(500),
	PruebaSeleccionId INT NOT NULL,
	UsuarioId INT,
    FechaActualizacion DATETIME,
	CONSTRAINT Preguntas_UsuarioId FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id),
	CONSTRAINT Preguntas_PruebaSeleccionId FOREIGN KEY (PruebaSeleccionId) REFERENCES PruebaSeleccion(Id),
);


