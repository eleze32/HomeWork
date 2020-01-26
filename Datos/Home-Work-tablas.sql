use [home-work];

create table hw.tipoUsuario(
	id int identity(1,1) not null,
	nombre varchar(15) not null,
	constraint PK_id primary key(id)
);

create table hw.usuario(
	id int identity(1,1) not null,
	nombre varchar(15) not null,
	apellido varchar(15) not null,
	email varchar(100) not null,
	numCelular varchar(20) not null,
	contrasenia varchar(20) not null,
	tipoUsuario int,
	constraint PK_id_usuario primary key(id),
	constraint FK_Usuario foreign key(tipoUsuario) references hw.tipoUsuario(id)
);

create table hw.tarea(
	id int identity(1,1) not null,
	nombre varchar(15) not null,
	constraint PK_id_tarea primary key(id)
);

create table hw.tareaPerteneceUsuario(
	id_tarea int not null,
	id_usuario int not null,
	constraint PK_Tarea_Usuario primary key(id_tarea,id_usuario),
	constraint FK_id_usuario foreign key(id_usuario) references hw.usuario(id),
	constraint FK_id_tarea foreign key(id_tarea) references hw.tarea(id)
);

create table hw.contraseña(
	id int not null,
	nombre varchar(20) not null,
	detalle varchar(100),
	usuario int not null,
	constraint PK_contraseña primary key(id),
	constraint FK_usuario_contraseña foreign key(usuario) references hw.usuario(id)
);

create table hw.recordatorio(
	id int not null,
	hora time(0),
	fecha date,
	detalle varchar(100),
	usuario int not null,
	constraint PK_recordatorio primary key(id),
	constraint FK_usuario_recordatorio foreign key(usuario) references hw.usuario(id)
);

create table hw.simple(
	id_recordatorio int not null,
	nombre varchar(20),
	constraint PK_recordatorioSimple primary key(id_recordatorio),
	constraint FK_RecordatorioSimple foreign key(id_recordatorio) references hw.recordatorio(id)
);

create table hw.TurnoMedico(
	id_recordatorio int not null,
	especialidad varchar(15),
	medico varchar(30),
	establecimiento varchar(20),
	direccion varchar(30),
	constraint PK_recordatorioTurnoMedico primary key(id_recordatorio),
	constraint FK_RecordatorioTUrnoMEdico foreign key(id_recordatorio) references hw.recordatorio(id)
);