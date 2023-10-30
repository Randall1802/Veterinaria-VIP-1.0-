create database VeteVIP
use VeteVIP

create table Cliente(
	idCliente int identity primary key,
	usuario varchar(30) unique not null,
	nombre varchar(50) not null,
	email varchar(100) not null,
	telefono varchar(10) not null,
	contrasena varchar(100) not null
)

create table Mascota(
	idMascota int identity primary key,
	idCliente int not null,
	nombre varchar(30) not null,
	raza varchar(30) not null,
	sexo varchar(15) not null,
	especie varchar(50) not null,
	fechaNacimiento datetime not null,
	edad varchar(2) not null,
	foreign key (idCliente) references Cliente(idCliente)
)

create table ServicioMedico(
	idMascota int not null,
	nombreMascota varchar(30) not null,
	tipoAtencion varchar(100) not null,
	fecha datetime not null,
	hora varchar(10) not null,
	tipoPago varchar(30) not null,
	foreign key (idMascota) references Mascota(idMascota)
)

create table ServicioEstetico(
	idMascota int not null,
	nombreMascota varchar(30) not null,
	servicio varchar(100) not null,
	fecha datetime not null,
	hora varchar(10) not null,
	tipoPago varchar(30) not null,
	foreign key (idMascota) references Mascota(idMascota)
)

create table Categoria(
	idCategoria int identity not null primary key,
	nombre varchar(100) not null,
	descripcion varchar(200) not null
)

create table Articulos(
	idArticulo int identity not null primary key,
	idCategoria int not null,
	nombreCategoria varchar(100) not null,
	nombreArticulo varchar(100) not null,
	precioUnitario int not null,
	stock int not null,
	foreign key (idCategoria) references Categoria(idCategoria)
)

create table Proveedores(
	idProveedor int identity not null primary key,
	nombre varchar(50) not null,
	ciudad varchar(50) not null,
	telefono varchar(10) not null,
	carga varchar(100) not null
)

create table Compras(
    idCompras int identity not null primary key,
	idArticulo int not null,
	idProveedor int not null,
	cantidad int not null,
	precioUnitario int not null,
	foreign key (idArticulo) references Articulos(idArticulo),
	foreign key (idProveedor) references Proveedores(idProveedor)
)

create table Ventas(
	idFactura int identity not null primary key,
	idCliente int not null, 
	idArticulo int not null,
	nombreArticulo varchar(100) not null,
	cantidadArticulo int not null,
	precioUnitario int not null,
	precioTotal int not null,
	foreign key (idCliente) references Cliente(idCliente),
	foreign key (idArticulo) references Articulos(idArticulo)
)

create table Consultas(
	idConsulta int identity primary key,
	Pregunta varchar(2000) unique not null,
	Respuesta varchar(2000) not null
)