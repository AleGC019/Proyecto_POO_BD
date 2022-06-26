--DB PROYECTO Version 1 

-- Creando tablas 

-------------------------------------------------------

CREATE DATABASE BPVX;
GO 

USE BPVX;
GO

-------------------------------------------------------

CREATE TABLE EJEMPLAR(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(100)NOT NULL,
	fecha_publicada DATE NOT NULL, 
	imagen_portada VARCHAR(1000),
	id_idioma int NOT NULL, --FK
	id_editorial int NOT NULL, --FK
	id_formato int NOT NULL, --FK
	isbn VARCHAR(100) NULL DEFAULT 'Identificador no definido',
	issn VARCHAR(100) NULL DEFAULT 'Identificador no definido',
	doi VARCHAR(100) NULL DEFAULT 'Identificador no definido',
	id_coleccion INT NOT NULL -- FK

);

CREATE TABLE EDITORIAL(
	id INT PRIMARY KEY IDENTITY,
	editorial VARCHAR(100)NOT NULL,
);

CREATE TABLE IDIOMA(
	id INT PRIMARY KEY IDENTITY,
	idioma VARCHAR(50)NOT NULL,
);

CREATE TABLE FORMATO(
	id INT PRIMARY KEY IDENTITY,
	formato VARCHAR(50)NOT NULL,
);

CREATE TABLE AUTOR(
	id INT PRIMARY KEY IDENTITY,
	autor VARCHAR(50)NOT NULL,
	id_ejemplar int NOT NULL --FK
);

CREATE TABLE PALABRAS_CLAVE(
	id INT PRIMARY KEY IDENTITY,
	palabra VARCHAR(50)NOT NULL,
	id_ejemplar int NOT NULL --FK
);

CREATE TABLE COLECCION(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(100)NOT NULL,
	id_genero int NOT NULL, --FK
	id_tipo int NOT NULL, --FK
	id_area int NOT NULL --FK
);

CREATE TABLE TIPO(
	id INT PRIMARY KEY IDENTITY,
	tipo VARCHAR(50)NOT NULL,

);

CREATE TABLE GENERO(
	id INT PRIMARY KEY IDENTITY,
	genero VARCHAR(50)NOT NULL,

);

CREATE TABLE EVENTO(
	id INT PRIMARY KEY IDENTITY,
	titulo VARCHAR(75)NOT NULL,
	imagen VARCHAR(1000),
	asistentes_cantidad INT NOT NULL CHECK (asistentes_cantidad > 0),
	incio_evento_hora_fecha DATETIME,
	finalizacion_evento_hora_fecha DATETIME,
	id_area int NOT NULL --FK

);

CREATE TABLE OBJETIVOS(
	id INT PRIMARY KEY IDENTITY, 
	objetivos VARCHAR(2500)NOT NULL,
	id_evento int NOT NULL --FK
);

CREATE TABLE AREA(
	id INT PRIMARY KEY IDENTITY, 
	nombre VARCHAR(100)NOT NULL,
	horario_inicio TIME NOT NULL,
	horario_cierre TIME NOT NULL,
	descripcion VARCHAR(2500),
	piso INT NOT NULL,
	id_responsable int NOT NULL --FK
);

CREATE TABLE PRESTAMO(
	id INT PRIMARY KEY IDENTITY, 
	prestamo_entrega_hora_fecha DATETIME,
	prestamo_devolucion_hora_fecha DATETIME,
	id_usuario int NOT NULL, --FK
	id_ejemplar int NOT NULL --FK
);

CREATE TABLE USUARIO(
	id INT PRIMARY KEY IDENTITY, 
	nombre VARCHAR(100)NOT NULL,
	ocupacion VARCHAR(100) DEFAULT 'ADMINISTRADOR',
	direccion VARCHAR(1000) DEFAULT 'Direccion no definida',
	correo VARCHAR(75)  DEFAULT 'ADMINISTRADOR',
	fotografia VARCHAR(1000),
	telefono CHAR(12)  UNIQUE CHECK (telefono LIKE '+503[2|6|7][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	institucion VARCHAR(100) DEFAULT 'BINEAS',
	contra VARCHAR(1000),
	id_rol INT -- Fk

);

CREATE TABLE RESERVACION (
    id INT PRIMARY KEY IDENTITY, 
	reservacion_hora_fecha DATETIME,
	prestamo_hora_fecha DATETIME,
	devolucion_hora_fecha DATETIME,
	id_usuario int NOT NULL, --FK
	id_ejemplar int NOT NULL --FK
);

CREATE TABLE RESPONSABLE (
	id INT PRIMARY KEY IDENTITY, 
	nombre_responsable VARCHAR(50)NOT NULL,
);

CREATE TABLE MOVILIZA (
	id INT PRIMARY KEY IDENTITY,
	ingreso_hora_fecha DATETIME,
	salida_hora_fecha DATETIME,
	id_usuario int NOT NULL, --FK
	id_area int NOT NULL --FK
);

CREATE TABLE ROL(
	id INT PRIMARY KEY IDENTITY,
	rol VARCHAR(100) NOT NULL
);

--****************************************************
-- PK/FK definition 
-- FK 19

ALTER TABLE EJEMPLAR 
ADD CONSTRAINT fk_id_idioma
FOREIGN KEY (id_idioma) 
REFERENCES IDIOMA(id)
ON DELETE CASCADE;

ALTER TABLE EJEMPLAR 
ADD CONSTRAINT fk_id_editorial
FOREIGN KEY (id_editorial) 
REFERENCES EDITORIAL (id)
ON DELETE CASCADE;

ALTER TABLE EJEMPLAR 
ADD CONSTRAINT fk_id_formato
FOREIGN KEY (id_formato) 
REFERENCES FORMATO (id)
ON DELETE CASCADE;

ALTER TABLE EJEMPLAR 
ADD CONSTRAINT fk_id_coleccion
FOREIGN KEY (id_coleccion) 
REFERENCES COLECCION (id)
ON DELETE CASCADE;

ALTER TABLE AUTOR
ADD CONSTRAINT fk_id_ejemplar
FOREIGN KEY (id_ejemplar) 
REFERENCES EJEMPLAR (id)
ON DELETE CASCADE;

ALTER TABLE PALABRAS_CLAVE
ADD CONSTRAINT fk_id_ejemplar2
FOREIGN KEY (id_ejemplar) 
REFERENCES EJEMPLAR (id)
ON DELETE CASCADE;

ALTER TABLE COLECCION
ADD CONSTRAINT fk_id_genero
FOREIGN KEY (id_genero) 
REFERENCES GENERO (id)
ON DELETE CASCADE;

ALTER TABLE COLECCION
ADD CONSTRAINT fk_id_tipo
FOREIGN KEY (id_tipo) 
REFERENCES TIPO (id)
ON DELETE CASCADE;

ALTER TABLE COLECCION
ADD CONSTRAINT fk_id_area
FOREIGN KEY (id_area) 
REFERENCES AREA (id)
ON DELETE CASCADE;

ALTER TABLE AREA
ADD CONSTRAINT fk_id_responsable
FOREIGN KEY (id_responsable) 
REFERENCES RESPONSABLE (id)
ON DELETE CASCADE;

ALTER TABLE EVENTO
ADD CONSTRAINT fk_id_area2
FOREIGN KEY (id_area) 
REFERENCES AREA (id)
ON DELETE CASCADE;

ALTER TABLE OBJETIVOS
ADD CONSTRAINT fk_id_evento
FOREIGN KEY (id_evento) 
REFERENCES EVENTO (id)
ON DELETE CASCADE;

ALTER TABLE MOVILIZA
ADD CONSTRAINT fk_id_usuario
FOREIGN KEY (id_usuario) 
REFERENCES USUARIO (id)
ON DELETE CASCADE;

ALTER TABLE MOVILIZA
ADD CONSTRAINT fk_id_area3
FOREIGN KEY (id_area) 
REFERENCES AREA (id)
ON DELETE CASCADE;

ALTER TABLE PRESTAMO
ADD CONSTRAINT fk_id_usuario2
FOREIGN KEY (id_usuario) 
REFERENCES USUARIO (id)
ON DELETE CASCADE;

ALTER TABLE PRESTAMO
ADD CONSTRAINT fk_id_ejemplar4
FOREIGN KEY (id_ejemplar) 
REFERENCES EJEMPLAR (id)
ON DELETE CASCADE;

ALTER TABLE RESERVACION
ADD CONSTRAINT fk_id_usuario3
FOREIGN KEY (id_usuario) 
REFERENCES USUARIO (id)
ON DELETE CASCADE;

ALTER TABLE RESERVACION
ADD CONSTRAINT fk_id_ejemplar3
FOREIGN KEY (id_ejemplar) 
REFERENCES EJEMPLAR (id)
ON DELETE CASCADE;

ALTER TABLE USUARIO
ADD CONSTRAINT fk_id_rol
FOREIGN KEY (id_rol)
REFERENCES ROL(id)
ON DELETE CASCADE;


--*********************************************************


-- Insertar datos en las tablas



INSERT INTO EDITORIAL(editorial)
	VALUES('Editorial Sudamericana');
INSERT INTO EDITORIAL(editorial)
	VALUES('Bloomsbury');
INSERT INTO EDITORIAL(editorial)
	VALUES('George Allen & Unwin HarperCollins');
INSERT INTO EDITORIAL(editorial)
	VALUES('Doubleday');
INSERT INTO EDITORIAL(editorial)
	VALUES('Macmillan Publishers');
INSERT INTO EDITORIAL(editorial)
	VALUES('A. Lacroix, Verboeckhoven & Ce. Bruselas');
INSERT INTO EDITORIAL(editorial)
	VALUES('Fondo de Cultura Economica');
INSERT INTO EDITORIAL(editorial)
	VALUES('El mensajero ruso');

-- Nuevas editoriales 

INSERT INTO EDITORIAL(editorial)
	VALUES('Editorial Mirahadas');
INSERT INTO EDITORIAL(editorial)
	VALUES('Alianza');
	INSERT INTO EDITORIAL(editorial)
	VALUES('Ariel');
INSERT INTO EDITORIAL(editorial)
	VALUES('Cátedra');
INSERT INTO EDITORIAL(editorial)
	VALUES('Akal');
INSERT INTO EDITORIAL(editorial)
	VALUES('Síntesis');
INSERT INTO EDITORIAL(editorial)
	VALUES('Marcial Pons');
INSERT INTO EDITORIAL(editorial)
	VALUES('Tecnos');
INSERT INTO EDITORIAL(editorial)
	VALUES('Aranzadi');
INSERT INTO EDITORIAL(editorial)
	VALUES('Aique Grupo Editor');
INSERT INTO EDITORIAL(editorial)
	VALUES('Algaida Editores');
INSERT INTO EDITORIAL(editorial)
	VALUES('Ediciones Aljibe');
INSERT INTO EDITORIAL(editorial)
	VALUES('Ediciones de Serval');
INSERT INTO EDITORIAL(editorial)
	VALUES('Editex Editorial');
INSERT INTO EDITORIAL(editorial)
	VALUES('Editorial Donostiarra');



-----------

INSERT INTO IDIOMA(idioma)
	VALUES('Español');
INSERT INTO IDIOMA(idioma)
	VALUES('Inglés');
INSERT INTO IDIOMA(idioma)
	VALUES('Frances');
INSERT INTO IDIOMA(idioma)
	VALUES('Portugues');
INSERT INTO IDIOMA(idioma)
	VALUES('Aleman');
INSERT INTO IDIOMA(idioma)
	VALUES('Ruso');

-----------

INSERT INTO FORMATO(formato)
	VALUES('Fisico');
INSERT INTO FORMATO(formato)
	VALUES('Digital');
INSERT INTO FORMATO(formato)
	VALUES('Audiolibro');

-----------

-----------

INSERT INTO TIPO(tipo)
	VALUES('Libros');
INSERT INTO TIPO(tipo)
	VALUES('Revista');
INSERT INTO TIPO(tipo)
	VALUES('Periodicos');
INSERT INTO TIPO(tipo)
	VALUES('Memorias');
INSERT INTO TIPO(tipo)
	VALUES('Albumes');
INSERT INTO TIPO(tipo)
	VALUES('Tesis');
INSERT INTO TIPO(tipo)
	VALUES('Audio');
INSERT INTO TIPO(tipo)
	VALUES('Video');

-----------

INSERT INTO GENERO(genero)
	VALUES('Aventura');
INSERT INTO GENERO(genero)
	VALUES('Ciencia Ficcion');
INSERT INTO GENERO(genero)
	VALUES('Policiaca');
INSERT INTO GENERO(genero)
	VALUES('Romantico');
INSERT INTO GENERO(genero)
	VALUES('Realismo Magico');

-----------

INSERT INTO RESPONSABLE(nombre_responsable)
	VALUES('Rufina Armengol Quintero');
INSERT INTO RESPONSABLE(nombre_responsable)
	VALUES('Pablo Torrijos Valderrama');
INSERT INTO RESPONSABLE(nombre_responsable)
	VALUES('Paulina Palma Donoso');
INSERT INTO RESPONSABLE(nombre_responsable)
	VALUES('Alejandro Pablo de Ribera');
INSERT INTO RESPONSABLE(nombre_responsable)
	VALUES('Eva Torrijos Valderramadee de Quintero');
-----------


INSERT INTO ROL(rol)
	VALUES('Administrador')
INSERT INTO ROL(rol)
	VALUES('Usuario')




-- Desarrollo de areas de Biblioteca
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de biblioteca 1', '00:00:00', '23:59:59', 'Espacio donde se preserva y se mantiene un registro cultural del pasado y del presente. Es un sitio donde podemos recurrir para leer, buscar información y estudiar.', 1, 1);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de biblioteca 2', '00:00:00', '23:59:59', 'Espacio donde se preserva y se mantiene un registro cultural del pasado y del presente. Es un sitio donde podemos recurrir para leer, buscar información y estudiar.', 1, 1);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de biblioteca 3', '00:00:00', '23:59:59', 'Espacio donde se preserva y se mantiene un registro cultural del pasado y del presente. Es un sitio donde podemos recurrir para leer, buscar información y estudiar.', 2, 2);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de biblioteca 4', '00:00:00', '23:59:59', 'Espacio donde se preserva y se mantiene un registro cultural del pasado y del presente. Es un sitio donde podemos recurrir para leer, buscar información y estudiar.', 2, 2);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de biblioteca 5', '00:00:00', '23:59:59', 'Espacio donde se preserva y se mantiene un registro cultural del pasado y del presente. Es un sitio donde podemos recurrir para leer, buscar información y estudiar.', 3, 3);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de biblioteca 6', '00:00:00', '23:59:59', 'Espacio donde se preserva y se mantiene un registro cultural del pasado y del presente. Es un sitio donde podemos recurrir para leer, buscar información y estudiar.', 3, 3);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de biblioteca 7', '00:00:00', '23:59:59', 'Espacio donde se preserva y se mantiene un registro cultural del pasado y del presente. Es un sitio donde podemos recurrir para leer, buscar información y estudiar.', 4, 5);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de biblioteca 8', '00:00:00', '23:59:59', 'Espacio donde se preserva y se mantiene un registro cultural del pasado y del presente. Es un sitio donde podemos recurrir para leer, buscar información y estudiar.', 4, 5);

-- Desarrollo de areas, Sala de investigacion

INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Sala de investigacion 1', '00:00:00', '23:59:59', 'Espacio destinados al desarrollo e implementacion de nuevas tecnicas. Disponible para reuniones y talleres entre alumnos y docentes.', 4, 4);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Sala de investigacion 2', '00:00:00', '23:59:59', 'Espacio destinados al desarrollo e implementacion de nuevas tecnicas. Disponible para reuniones y talleres entre alumnos y docentes.', 4, 4);

-- Desarrollo de area de computacion


INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de computacion 1', '00:00:00', '23:59:59', 'Espacio destinado para el uso de computadoras en concepto educativo.', 1, 1);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de computacion 2', '00:00:00', '23:59:59',  'Espacio destinado para el uso de computadoras en concepto educativo.', 1, 1);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de computacion 3', '00:00:00', '23:59:59', 'Espacio destinado para el uso de computadoras en concepto educativo.', 2, 2);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de computacion 4', '00:00:00', '23:59:59',  'Espacio destinado para el uso de computadoras en concepto educativo.', 2, 2);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de computacion 5', '00:00:00', '23:59:59', 'Espacio destinado para el uso de computadoras en concepto educativo.', 3, 3);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de computacion 6', '00:00:00', '23:59:59', 'Espacio destinado para el uso de computadoras en concepto educativo.', 3, 3);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de computacion 7', '00:00:00', '23:59:59',  'Espacio destinado para el uso de computadoras en concepto educativo.', 4, 5);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de computacion 8', '00:00:00', '23:59:59',  'Espacio destinado para el uso de computadoras en concepto educativo.', 4, 5);

-- Desarrollo Arae de promocion de inclusion 

INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de promocion de inclusion 1', '08:00:00', '16:00:00', 'Espacio destinado a las personas con discapacidades con el objetivo de que estas puedan desarrollar sus actividades con normalidad.', 1, 1);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Area de promocion de inclusion 2', '08:00:00', '16:00:00', 'Espacio destinado a las personas con discapacidades con el objetivo de que estas puedan desarrollar sus actividades con normalidad.', 1, 1);

-- Desarrollo de Area, Sala de proyeccion

INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Sala de proyeccion 1', '08:00:00', '16:00:00', 'Espacio destinado a la exposicion de contenido audio visual', 2, 2);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Sala de proyeccion 2', '08:00:00', '16:00:00', 'Espacio destinado a la exposicion de contenido audio visual', 3, 3);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Sala de proyeccion 3', '08:00:00', '16:00:00', 'Espacio destinado a la exposicion de contenido audio visual', 4, 5);

--- Desarrollo de areas Auditorium

INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Auditorium', '08:00:00', '16:00:00', 'Espacio destinado a la exposicion del arte, charlas, discusiones y conmemoraciones.', 1, 4);

-- Desarrollo areas, Salones ludicos

INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Salon ludico 1', '08:00:00', '16:00:00', 'Espacio destinado al descanso, aseo y juego libre.', 1, 1);
INSERT INTO AREA(nombre, horario_inicio, horario_cierre, descripcion, piso, id_responsable)
	VALUES('Salon ludico 2', '08:00:00', '16:00:00', 'Espacio destinado al descanso, aseo y juego libre.', 2, 2);

-----------

--********************************************************************************************************************************************************

------------

INSERT INTO USUARIO(nombre, ocupacion, direccion, correo, fotografia, telefono, institucion, id_rol, contra)
	VALUES('Fernando Andres Eguizabal Medrano', 'Estudiante', '6414 Geo Burg Apt. 928', 'gabe92@hotmail.com', 'dhdthdthdthfy', '+50325116080', 'Universidad Centroamericana Jose Simeon Cañas', 2, 'CMdsnOgzesM71Kut' );
INSERT INTO USUARIO(nombre, ocupacion, direccion, correo, fotografia, telefono, institucion, id_rol, contra)
	VALUES('Pamela Alejandra Gomez Segovia', 'Chef', '80014 Rowe Inlet','funk.maggie@abernathy.com', 'dhdthdthdthfy', '+50379218466', 'Lobby Gastro Bar', 2, 'uXhhoVzYuUgB6xUu');
INSERT INTO USUARIO(nombre, ocupacion, direccion, correo, fotografia, telefono, institucion, id_rol, contra)
	VALUES('Claudia Maria Chavez Grande', 'Psicologa', '3272 Cheyanne Road', 'roderick34@gmail.com', 'dhdthdthdthfy',  '+50377995565', 'Hospital Militar', 2, 'FBndnkBhSYCRPHB2');
INSERT INTO USUARIO(nombre, ocupacion, direccion, correo, fotografia, telefono, institucion, id_rol, contra)
	VALUES('Carlos Alejandro Gomez Handal', 'Medico', '390 Hill Fields', 'rullrich@hotmail.com','dhdthdthdthfy', '+50322051480', 'Hospital Nacional Especializado Rosales', 2, 'dAJ4xIbn1lKxX1iBF');
INSERT INTO USUARIO(nombre, ocupacion, direccion, correo, fotografia, telefono, institucion, id_rol, contra)
	VALUES('Diego Fernando Olivo Perez', 'Dentista', '516 Eryn Plains Apt. 458', 'delmer98@hotmail.com', 'dhdthdthdthfy', '+50367774202', 'Centro Odontologico Americano', 2, '56J90HcdAJ4xi7kS');
INSERT INTO USUARIO(nombre, fotografia, telefono, id_rol, contra)
	VALUES('Francisco Javier Luque Sancho',  'dhdthdthdthfy', '+50325119080', 1, '56J90HcdlKxX1iBF');
INSERT INTO USUARIO(nombre, fotografia, telefono, id_rol, contra)
	VALUES('Victor Manuel Casals Rivero',  'dhdthdthdthfy', '+50325116070', 1, 'uXhhnOglKxX1iBF');
INSERT INTO USUARIO(nombre, fotografia,  telefono , id_rol, contra)
	VALUES('Lázaro Benitez Becerra',  'dhdthdthdthfy', '+50325126080', 1, 'dAJ4xsnOglBJQ4Ibn');
INSERT INTO USUARIO(nombre, fotografia, telefono,  id_rol, contra)
	VALUES('Juan Pablo Serna Galvez',  'dhdthdthdthfy', '+50325116580', 1, 'CMdsnOgFBndn');
INSERT INTO USUARIO(nombre, fotografia, telefono, id_rol, contra)
	VALUES('María Carmen Pallarès Tejedor', 'dhdthdthdthfy', '+50325196080', 1, 'gzessnO56J90Hcd');


----------


-------------------------------


INSERT INTO COLECCION(nombre, id_genero, id_tipo, id_area)
	VALUES('COLECCION 1',5, 1, 4);
INSERT INTO COLECCION(nombre, id_genero, id_tipo, id_area)
	VALUES('COLECCION 2',1, 7, 12);
INSERT INTO COLECCION(nombre, id_genero, id_tipo, id_area)
	VALUES('COLECCION 3',1, 1, 16);
INSERT INTO COLECCION(nombre, id_genero, id_tipo, id_area)
	VALUES('COLECCION 4',3, 7, 15);
INSERT INTO COLECCION(nombre, id_genero, id_tipo, id_area)
	VALUES('COLECCION 5',4, 1, 2);
INSERT INTO COLECCION(nombre, id_genero, id_tipo, id_area)
	VALUES('COLECCION 6',3, 1, 5);
INSERT INTO COLECCION(nombre, id_genero, id_tipo, id_area)
	VALUES('COLECCION 7',1, 1, 8);
INSERT INTO COLECCION(nombre, id_genero, id_tipo, id_area)
	VALUES('COLECCION 8',3, 1, 1);


-------------

---------

INSERT INTO EJEMPLAR(nombre, fecha_publicada, imagen_portada, id_idioma, id_editorial, id_formato, isbn,id_coleccion)
	VALUES('Cien años de soledad', CONVERT(DATE,'5/3/1967',103), 'Direccion Foto', 1, 1, 1, '8143787233994', 1);
INSERT INTO EJEMPLAR(nombre, fecha_publicada, imagen_portada, id_idioma, id_editorial, id_formato, isbn, issn,id_coleccion)
	VALUES('Harry Potter y la piedra filosofal', CONVERT(DATE,'30/6/1997',103), 'Direccion Foto', 2, 2, 3, '5182989380115', '11448753', 2);
INSERT INTO EJEMPLAR(nombre, fecha_publicada, imagen_portada, id_idioma, id_editorial, id_formato, issn,id_coleccion)
	VALUES('El señor de los Anillos', CONVERT(DATE,'29/7/1954',103), 'Direccion Foto', 2, 3, 2, '11448757', 3);
INSERT INTO EJEMPLAR(nombre, fecha_publicada, imagen_portada, id_idioma, id_editorial, id_formato, isbn, doi,id_coleccion)
	VALUES('El codigo Da Vinci', CONVERT(DATE,'18/3/2003',103), 'Direccion Foto', 5, 4, 3, '3417041803489','10.4067/S0771807642010000500002', 4);
INSERT INTO EJEMPLAR(nombre, fecha_publicada, imagen_portada, id_idioma, id_editorial, id_formato, isbn, issn,id_coleccion)
	VALUES('Lo que el viento se llevo', CONVERT(DATE,'30/6/1936',103), 'Direccion Foto', 4, 5, 1, '9700169168290', '11448751', 5);
INSERT INTO EJEMPLAR(nombre, fecha_publicada, imagen_portada, id_idioma, id_editorial, id_formato, isbn, issn,id_coleccion)
	VALUES('Los miserables', CONVERT(DATE,'03/04/1862',103), 'Direccion Foto', 3, 6, 1, '9700169168235', '11448780', 6);
INSERT INTO EJEMPLAR(nombre, fecha_publicada, imagen_portada, id_idioma, id_editorial, id_formato, issn,id_coleccion)
	VALUES('Pedro Paramo', CONVERT(DATE,'07/01/1967',103), 'Direccion Foto', 1, 7, 1, '11448700', 7);
INSERT INTO EJEMPLAR(nombre, fecha_publicada, imagen_portada, id_idioma, id_editorial, id_formato, isbn,id_coleccion)
	VALUES('Crimen y castigo', CONVERT(DATE,'12/12/1866',103), 'Direccion Foto', 6, 8, 1, '9700169168300', 8);

-----------

-----------

INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('Soledad', 1);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('Realismo Magico', 1);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('Buendia', 1);


INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('Magia', 2);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('Emma Watson', 2);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('Quidditch', 2);


INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('Las dos torres', 3);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('Sauron', 3);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('Tolkein', 3);


INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('misterioso', 4);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('museo', 4);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('novela', 4);


INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('clasico', 5);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('ficcion historica', 5);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('epico', 5);


INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('justicia', 6);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('mal', 6);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('etica', 6);


INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('juan preciado', 7);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('lugar vacio', 7);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('sin vida', 7);


INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('verdad', 8);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('arrepentimiento', 8);
INSERT INTO PALABRAS_CLAVE(palabra, id_ejemplar)
	VALUES('amor', 8);




-----------


INSERT INTO AUTOR(autor, id_ejemplar)
	VALUES('Gabriel Garcia Marquez', 1);
INSERT INTO AUTOR(autor, id_ejemplar)
	VALUES('J. K. Rowling', 2);
INSERT INTO AUTOR(autor, id_ejemplar)
	VALUES('J. R. R. Tolkein', 3);
INSERT INTO AUTOR(autor, id_ejemplar)
	VALUES('Dan Brown', 4);
INSERT INTO AUTOR(autor, id_ejemplar)
	VALUES('Margaret Mitchell', 5);
INSERT INTO AUTOR(autor, id_ejemplar)
	VALUES('Victor Hugo', 6);
INSERT INTO AUTOR(autor, id_ejemplar)
	VALUES('Juan Ruflo', 7);
INSERT INTO AUTOR(autor, id_ejemplar)
	VALUES('Fiodor Dostoievski', 8);

--------------

INSERT INTO EVENTO(titulo, imagen, asistentes_cantidad, incio_evento_hora_fecha, finalizacion_evento_hora_fecha, id_area)
	VALUES('Conmemoración del Día de la Mujer', '00', 50, '20220308 14:00:00', '20220308 18:00:00', 9);

INSERT INTO EVENTO(titulo, imagen, asistentes_cantidad, incio_evento_hora_fecha, finalizacion_evento_hora_fecha, id_area)
	VALUES('Presentación del libro Amores Intensos', '01', 200, '20220210 10:00:00', '20220210 12:00:00', 21);

INSERT INTO EVENTO(titulo, imagen, asistentes_cantidad, incio_evento_hora_fecha, finalizacion_evento_hora_fecha, id_area)
	VALUES('Refuerzos escolares', '02', 25, '20220618 10:00:00', '20220622 18:00:00', 11);

INSERT INTO EVENTO(titulo, imagen, asistentes_cantidad, incio_evento_hora_fecha, finalizacion_evento_hora_fecha, id_area)
	VALUES('Feria de Ciencia', '03', 358, '20220103 10:00:00', '20220109 15:00:00', 24);

INSERT INTO EVENTO(titulo, imagen, asistentes_cantidad, incio_evento_hora_fecha, finalizacion_evento_hora_fecha, id_area)
	VALUES('Fiesta del libro', '04', 50, '20220423 08:00:00', '20220423 16:00:00', 1);

-----------

INSERT INTO OBJETIVOS(objetivos, id_evento)
	VALUES('Promover la consciencia social de la realidad de la mujer, las amenazas de las que se ve víctima y las propuestas para erradicar pensamientos y actitudes dañinas.', 1);

INSERT INTO OBJETIVOS(objetivos, id_evento)
	VALUES('Educar a la población en temáticas de identidad de género.', 1);

INSERT INTO OBJETIVOS(objetivos, id_evento)
	VALUES('Abrir un espacio de diálogo para debatir ideas de forma respetuosa.', 1);

INSERT INTO OBJETIVOS(objetivos, id_evento)
	VALUES('Generar publicidad para la venta de la obra literaria Amores Intensos.',2);

INSERT INTO OBJETIVOS(objetivos, id_evento)
	VALUES('Proveer de colaboración académica para alumnos de zonas aledañas que permitan reforzar contenidos escolares deficientes.',3);

INSERT INTO OBJETIVOS(objetivos, id_evento)
	VALUES('Ausipiciar un ambiente de descubrimiento y conocimiento de las ciencias.',4);

INSERT INTO OBJETIVOS(objetivos, id_evento)
	VALUES('Originar interés en los distintos visitantes de la biblioteca para hacer uso de las instalaciones y de los materiales bibliográficos.',5);

INSERT INTO OBJETIVOS(objetivos, id_evento)
	VALUES('Ofrecer recorridos de las nuevas instalaciones de BINAES.', 5);

--********************************************************************************************************************************************************

-----------

INSERT INTO PRESTAMO(prestamo_entrega_hora_fecha, prestamo_devolucion_hora_fecha, id_usuario, id_ejemplar)
	VALUES(CONVERT(DATETIME, '22/06/2022 10:00:00', 103), CONVERT(DATETIME, '27/06/2022 10:00:00', 103),1,1);
INSERT INTO PRESTAMO(prestamo_entrega_hora_fecha, prestamo_devolucion_hora_fecha, id_usuario, id_ejemplar)
	VALUES(CONVERT(DATETIME, '23/06/2022 12:00:00', 103), CONVERT(DATETIME, '28/06/2022 12:00:00', 103),2,5);
INSERT INTO PRESTAMO(prestamo_entrega_hora_fecha, prestamo_devolucion_hora_fecha, id_usuario, id_ejemplar)
	VALUES(CONVERT(DATETIME, '24/06/2022 11:00:00', 103), CONVERT(DATETIME, '29/06/2022 11:00:00', 103),3,6);
INSERT INTO PRESTAMO(prestamo_entrega_hora_fecha, prestamo_devolucion_hora_fecha, id_usuario, id_ejemplar)
	VALUES(CONVERT(DATETIME, '25/06/2022 14:00:00', 103), CONVERT(DATETIME, '30/06/2022 14:00:00', 103),4,7);
INSERT INTO PRESTAMO(prestamo_entrega_hora_fecha, prestamo_devolucion_hora_fecha, id_usuario, id_ejemplar)
	VALUES(CONVERT(DATETIME, '26/06/2022 11:30:00', 103), CONVERT(DATETIME, '01/07/2022 11:30:00', 103),5,8);

-----------------

/*

-- Este apartado fue utilizado con el objeto de hacer comprobaciones en el desarrollo del programa
-- El objeto de dejarlo comentado es resaltar la importancia que este posee en el desarrollo de las tablas del modelo normalizado
-- No obstante, este inserción de datos puede ser descomentada y utilizada

INSERT INTO RESERVACION(reservacion_hora_fecha, prestamo_hora_fecha,devolucion_hora_fecha, id_usuario, id_ejemplar)
	VALUES(CONVERT(DATETIME, '23/06/2022 10:30:00', 103), CONVERT(DATETIME, '28/06/2022 10:00:00', 103), CONVERT(DATETIME, '03/07/2022 10:00:00', 103),5,1);
INSERT INTO RESERVACION(reservacion_hora_fecha, prestamo_hora_fecha,devolucion_hora_fecha, id_usuario, id_ejemplar)
	VALUES(CONVERT(DATETIME, '24/06/2022 13:00:00', 103), CONVERT(DATETIME, '29/06/2022 10:00:00', 103), CONVERT(DATETIME, '04/07/2022 10:00:00', 103),4,5);
INSERT INTO RESERVACION(reservacion_hora_fecha, prestamo_hora_fecha,devolucion_hora_fecha, id_usuario, id_ejemplar)
	VALUES(CONVERT(DATETIME, '25/06/2022 12:00:00', 103), CONVERT(DATETIME, '30/06/2022 10:00:00', 103), CONVERT(DATETIME, '05/07/2022 10:00:00', 103),3,6);
INSERT INTO RESERVACION(reservacion_hora_fecha, prestamo_hora_fecha,devolucion_hora_fecha, id_usuario, id_ejemplar)
	VALUES(CONVERT(DATETIME, '26/06/2022 14:00:00', 103), CONVERT(DATETIME, '01/07/2022 10:00:00', 103), CONVERT(DATETIME, '06/07/2022 10:00:00', 103),2,7);
INSERT INTO RESERVACION(reservacion_hora_fecha, prestamo_hora_fecha,devolucion_hora_fecha, id_usuario, id_ejemplar)
	VALUES(CONVERT(DATETIME, '27/06/2022 10:00:00', 103), CONVERT(DATETIME, '02/07/2022 10:00:00', 103), CONVERT(DATETIME, '07/07/2022 10:00:00', 103),1,8);


*/

-----------

-----------

INSERT INTO MOVILIZA(ingreso_hora_fecha, salida_hora_fecha, id_usuario, id_area)
	VALUES(CONVERT(DATETIME, '22/06/2022 09:08:19', 103), CONVERT(DATETIME, '22/06/2022 11:00:30', 103), 1, 4);
INSERT INTO MOVILIZA(ingreso_hora_fecha, salida_hora_fecha, id_usuario, id_area)
	VALUES(CONVERT(DATETIME, '23/06/2022 11:00:25', 103), CONVERT(DATETIME, '23/06/2022 15:30:00', 103), 2, 2);
INSERT INTO MOVILIZA(ingreso_hora_fecha, salida_hora_fecha, id_usuario, id_area)
	VALUES(CONVERT(DATETIME, '24/06/2022 10:08:00', 103), CONVERT(DATETIME, '24/06/2022 14:10:00', 103), 3, 5);
INSERT INTO MOVILIZA(ingreso_hora_fecha, salida_hora_fecha, id_usuario, id_area)
	VALUES(CONVERT(DATETIME, '25/06/2022 12:25:00', 103), CONVERT(DATETIME, '25/06/2022 16:00:00', 103), 4, 8);
INSERT INTO MOVILIZA(ingreso_hora_fecha, salida_hora_fecha, id_usuario, id_area)
	VALUES(CONVERT(DATETIME, '26/06/2022 08:30:00', 103), CONVERT(DATETIME, '26/06/2022 15:45:00', 103), 5, 1);

INSERT INTO MOVILIZA(ingreso_hora_fecha, salida_hora_fecha, id_usuario, id_area)
	VALUES(CONVERT(DATETIME, '23/06/2022 10:08:19', 103), CONVERT(DATETIME, '23/06/2022 12:00:30', 103), 1, 1);
INSERT INTO MOVILIZA(ingreso_hora_fecha, salida_hora_fecha, id_usuario, id_area)
	VALUES(CONVERT(DATETIME, '24/06/2022 12:00:25', 103), CONVERT(DATETIME, '24/06/2022 16:00:00', 103), 2, 8);
INSERT INTO MOVILIZA(ingreso_hora_fecha, salida_hora_fecha, id_usuario, id_area)
	VALUES(CONVERT(DATETIME, '25/06/2022 11:08:00', 103), CONVERT(DATETIME, '25/06/2022 15:10:00', 103), 3, 5);
INSERT INTO MOVILIZA(ingreso_hora_fecha, salida_hora_fecha, id_usuario, id_area)
	VALUES(CONVERT(DATETIME, '26/06/2022 13:25:00', 103), CONVERT(DATETIME, '26/06/2022 15:50:00', 103), 4, 2);
INSERT INTO MOVILIZA(ingreso_hora_fecha, salida_hora_fecha, id_usuario, id_area)
	VALUES(CONVERT(DATETIME, '27/06/2022 09:30:00', 103), CONVERT(DATETIME, '27/06/2022 16:00:00', 103), 5, 4);


--*************************************************
