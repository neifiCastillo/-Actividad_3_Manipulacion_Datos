
  -- 1) Crear Base de Datos
CREATE DATABASE PracticaBD_Tienda;
GO

USE PracticaBD_Tienda;
GO

   --2) TABLA: Categorías
CREATE TABLE Categorias (
    CategoriaID INT IDENTITY(1,1) NOT NULL,
    NombreCategoria VARCHAR(50) NOT NULL
	CONSTRAINT PK_Categorias PRIMARY KEY (CategoriaID)
);

  -- 3) TABLA: Productos
CREATE TABLE Productos (
    ProductoID INT IDENTITY(1,1) NOT NULL,
    NombreProducto VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255) NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL CONSTRAINT DF_Productos_Stock DEFAULT(0),
    CategoriaID INT NULL,
	CONSTRAINT PK_Productos PRIMARY KEY (ProductoID),
	CONSTRAINT FK_Productos_Categorias FOREIGN KEY (CategoriaID) REFERENCES Categorias(CategoriaID)
);

 --4) TABLA: Clientes
CREATE TABLE Clientes (
    ClienteID INT IDENTITY(1,1) NOT NULL,
    NombreCompleto VARCHAR(150) NOT NULL,
    CorreoElectronico VARCHAR(100) NULL,
    Telefono VARCHAR(15) NULL,
    Direccion VARCHAR(255) NULL,
	CONSTRAINT PK_Clientes PRIMARY KEY (ClienteID),
);

  --5)TABLA: Facturas
CREATE TABLE Facturas (
    FacturaID INT IDENTITY(1,1) NOT NULL,
    ClienteID INT NOT NULL,
    FechaFactura DATE NOT NULL,
    Total DECIMAL(10,2) NOT NULL, 
	CONSTRAINT PK_Facturas PRIMARY KEY (FacturaID),
	CONSTRAINT FK_Facturas_Clientes FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID)
);

   --6) TABLA: DetallesFactura
CREATE TABLE DetallesFactura (
    DetalleID INT IDENTITY(1,1) NOT NULL,
    FacturaID INT NOT NULL,
    ProductoID INT NOT NULL,
    Cantidad INT NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Impuesto DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
	CONSTRAINT PK_DetallesFactura PRIMARY KEY (DetalleID),
	CONSTRAINT FK_DetallesFactura_Facturas FOREIGN KEY (FacturaID) REFERENCES Facturas(FacturaID),
	CONSTRAINT FK_DetallesFactura_Productos FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
);

   --7) TABLA: Proveedores
CREATE TABLE Proveedores (
    ProveedorID INT IDENTITY(1,1) NOT NULL,
    NombreProveedor VARCHAR(100) NOT NULL,
    Telefono VARCHAR(15) NULL,
    CorreoElectronico VARCHAR(100) NULL,
	CONSTRAINT PK_Proveedores PRIMARY KEY (ProveedorID)
);

   --8) TABLA: Compras
CREATE TABLE Compras (
    CompraID INT IDENTITY(1,1) NOT NULL,
    ProveedorID INT NOT NULL,
    FechaCompra DATE NOT NULL,
    Total DECIMAL(10,2) NOT NULL,
	CONSTRAINT PK_Compras PRIMARY KEY (CompraID),
	CONSTRAINT FK_Compras_Proveedores FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID)
);

   --9) TABLA: DetallesCompra
CREATE TABLE DetallesCompra (
    DetalleCompraID INT IDENTITY(1,1) NOT NULL,
    CompraID INT NOT NULL,
    ProductoID INT NOT NULL,
    Cantidad INT NOT NULL,
    CostoUnitario DECIMAL(10,2) NOT NULL,
    Impuesto DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
	CONSTRAINT PK_DetallesCompra PRIMARY KEY (DetalleCompraID),
	CONSTRAINT FK_DetallesCompra_Compras FOREIGN KEY (CompraID) REFERENCES Compras(CompraID),
	CONSTRAINT FK_DetallesCompra_Productos FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
);

