CREATE DATABASE ConstructoraUH;
-- Tabla de Empleados
CREATE TABLE Empleados (
    CarnetUnico INT PRIMARY KEY,
    NombreCompleto NVARCHAR(100) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Direccion NVARCHAR(200) DEFAULT 'San José',
    Telefono NVARCHAR(15) NOT NULL,
    CorreoElectronico NVARCHAR(100) UNIQUE NOT NULL,
    Salario DECIMAL(10,2) CHECK (Salario >= 250000 AND Salario <= 500000) DEFAULT 250000,
    Categoria NVARCHAR(50) NOT NULL CHECK (Categoria IN ('Administrador', 'Operario', 'Peon'))
);

-- Tabla de Proyectos
CREATE TABLE Proyectos (
    Codigo INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(150) NOT NULL,
    FechaInicio DATE NOT NULL,
    FechaFin DATE NULL
);

-- Tabla de Asignaciones de Personal a Proyectos
CREATE TABLE AsignacionProyectos (
    Id INT PRIMARY KEY IDENTITY,
    EmpleadoId INT NOT NULL,
    ProyectoId INT NOT NULL,
    FechaAsignacion DATE DEFAULT GETDATE(),
    FOREIGN KEY (EmpleadoId) REFERENCES Empleados(CarnetUnico),
    FOREIGN KEY (ProyectoId) REFERENCES Proyectos(Codigo)
);
