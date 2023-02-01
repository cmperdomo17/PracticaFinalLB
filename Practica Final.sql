/*UNIVERSO DEL DISCURSO

ZyzzApp es una aplicación de gestión de rutinas personalizadas de gym. 
Los usuarios pueden crear su propio plan de entrenamiento personalizado
basado en su nivel de condición física, objetivos y disponibilidad de tiempo.
La aplicación también ofrece acceso a una variedad de ejercicios con demos y
tutoriales en video para ayudar a los usuarios a realizar los ejercicios correctamente.

La aplicación también permite a los usuarios registrar su progreso y ver su evolución
a través de gráficos y estadísticas. Los usuarios también pueden compartir sus logros 
y metas con amigos y seguidores en la aplicación. Además, ZyzzApp tiene una función de 
seguimiento de nutrición, donde los usuarios pueden registrar lo que comen y obtener
recomendaciones de alimentación personalizadas para alcanzar sus objetivos de
acondicionamiento físico.

La aplicación también ofrece una variedad de contenido exclusivo, como entrevistas
con entrenadores profesionales y atletas, así como artículos sobre nutrición 
y acondicionamiento físico.

ZyzzApp también ofrece una opción de suscripción premium que permite a los usuarios
acceder a contenido adicional y funciones avanzadas, como la posibilidad de crear planes
de entrenamiento personalizados con un entrenador personal.

ENTIDADES:
• USUARIO
• PLAN DE ENTRENAMIENTO
• EJERCICIOS
• PROGRESO
• NUTRICIÓN
• ENTRENADOR
• ATLETA
• SUSCRIPCIÓN
*/

CREATE TABLE USUARIO (
    ID_USUARIO INT PRIMARY KEY,
    NOMBRE VARCHAR(50) NOT NULL,
    APELLIDO VARCHAR(50) NOT NULL,
    EDAD INT NOT NULL,
    PESO FLOAT NOT NULL,
    ALTURA FLOAT NOT NULL,
    OBJETIVO VARCHAR(50) NOT NULL,
    ESTADO VARCHAR(200),
    NUM_ENTRENAMIENTOS INT,
    NUM_SEGUIDORES INT,
    NUM_SIGUIENDO INT
);

CREATE TABLE RUTINA (
  ID_RUTINA INT PRIMARY KEY,
  NOMBRE VARCHAR(50) NOT NULL,
  DESCRIPCION VARCHAR(255),
  NIVEL INT NOT NULL
);

CREATE TABLE EJERCICIO (
  ID_EJERCICIO INT PRIMARY KEY,
  NOMBRE VARCHAR(50) NOT NULL,
  TIPO VARCHAR(50) NOT NULL,
  DESCRIPCION VARCHAR(255)
);

CREATE TABLE RUTINA_EJERCICIO (
  ID_RUTINA INT,
  ID_EJERCICIO INT,
  SERIES INT NOT NULL,
  REPETICIONES INT NOT NULL,
  FOREIGN KEY (ID_RUTINA) REFERENCES RUTINA(ID_RUTINA),
  FOREIGN KEY (ID_EJERCICIO) REFERENCES EJERCICIO(ID_EJERCICIO)
);

CREATE TABLE CLIENTE_RUTINA (
  ID_USUARIO INT,
  ID_RUTINA INT,
  FOREIGN KEY (ID_USUARIO) REFERENCES USUARIO(ID_USUARIO),
  FOREIGN KEY (ID_RUTINA) REFERENCES RUTINA(ID_RUTINA)
);


/*INSERTS USUARIO

    INSERT INTO USUARIO VALUES (1, 'Mario', 'Perdomo', 20, 67.0, 1.65, 'Aumentar masa muscular', 'Estudiante', 30, 25, 2);
    INSERT INTO USUARIO VALUES (2, 'Santiago', 'Agredo', 20, 68.0, 1.65, 'Perder peso', 'Estudiante', 40, 20, 5);
    INSERT INTO USUARIO VALUES (3, 'Pedro', 'Lopez', 35, 80.0, 1.90, 'Mejorar resistencia', 'Empleado', 8, 15, 3);
    INSERT INTO USUARIO VALUES (4, 'Carlos', 'Martinez', 40, 95.0, 1.75, 'Aumentar fuerza', 'Jubilado', 2, 5, 10);
    INSERT INTO USUARIO VALUES (5, 'Ana', 'Gomez', 45, 60.0, 1.70, 'Mantener forma', 'Amamte de ejercicios', 6, 30, 8);*/

/*INSERTS RUTINA
INSERT INTO RUTINA (ID_RUTINA, NOMBRE, DESCRIPCION, NIVEL) VALUES (1, 'Rutina de Fuerza', 'Este es un plan de entrenamiento diseñado para aumentar la masa muscular y la fuerza', 3);
INSERT INTO RUTINA (ID_RUTINA, NOMBRE, DESCRIPCION, NIVEL) VALUES (2, 'Rutina de Cardio', 'Este es un plan de entrenamiento diseñado para mejorar la resistencia cardiovascular y quemar grasa', 2);
INSERT INTO RUTINA (ID_RUTINA, NOMBRE, DESCRIPCION, NIVEL) VALUES (3, 'Rutina de Flexibilidad', 'Este es un plan de entrenamiento diseñado para mejorar la flexibilidad y la movilidad', 1);
INSERT INTO RUTINA (ID_RUTINA, NOMBRE, DESCRIPCION, NIVEL) VALUES (4, 'Rutina de Hipertrofia', 'Este es un plan de entrenamiento diseñado para aumentar el tamaño muscular', 3);
INSERT INTO RUTINA (ID_RUTINA, NOMBRE, DESCRIPCION, NIVEL) VALUES (5, 'Rutina de Tonificacion', 'Este es un plan de entrenamiento diseñado para tonificar y dar forma al cuerpo', 2);
*/

/* INSERTS EJERCICIO
INSERT INTO EJERCICIO (ID_EJERCICIO, NOMBRE, TIPO, DESCRIPCION) VALUES (1, 'Sentadillas', 'Pierna', 'Ejercicio para fortalecer los músculos de las piernas');
INSERT INTO EJERCICIO (ID_EJERCICIO, NOMBRE, TIPO, DESCRIPCION) VALUES (2, 'Fondos', 'Pecho', 'Ejercicio para fortalecer los músculos del pecho');
INSERT INTO EJERCICIO (ID_EJERCICIO, NOMBRE, TIPO, DESCRIPCION) VALUES (3, 'Flexiones', 'Brazo', 'Ejercicio para fortalecer los músculos de los brazos');
INSERT INTO EJERCICIO (ID_EJERCICIO, NOMBRE, TIPO, DESCRIPCION) VALUES (4, 'Abdominales', 'Abdominales', 'Ejercicio para fortalecer los músculos abdominales');
INSERT INTO EJERCICIO (ID_EJERCICIO, NOMBRE, TIPO, DESCRIPCION) VALUES (5, 'Remo con barra', 'Espalda', 'Ejercicio para fortalecer los músculos de la espalda');
*/

/*INSERTS RUTINA_EJERCICIO
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (1, 1, 3, 8);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (1, 2, 3, 12);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (1, 3, 3, 10);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (2, 4, 3, 20);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (2, 5, 3, 30);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (2, 1, 3, 12);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (3, 1, 3, 8);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (3, 2, 3, 6);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (3, 4, 3, 12);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (4, 3, 3, 12);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (4, 2, 3, 10);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (4, 1, 3, 12);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (5, 5, 3, 8);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (5, 2, 3, 10);
INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, SERIES, REPETICIONES) VALUES (5, 3, 3, 12);*/

/* INSERTS CLIENTE_RUTINA
INSERT INTO CLIENTE_RUTINA VALUES (1, 1);

INSERT INTO CLIENTE_RUTINA VALUES (2, 1);

INSERT INTO CLIENTE_RUTINA VALUES (3, 3);

INSERT INTO CLIENTE_RUTINA VALUES (4, 4);

INSERT INTO CLIENTE_RUTINA VALUES (5, 5); */

select usuario.NOMBRE as NombreUsuario, usuario.APELLIDO as ApellidoUsuario,
       rutina.NOMBRE as NombreRutina, rutina.DESCRIPCION as DescripcionRutina, 
       ejercicio.NOMBRE as NombreEjercicio, ejercicio.DESCRIPCION as DescripcionEjercicio
from CLIENTE_RUTINA 
inner join usuario on CLIENTE_RUTINA.ID_USUARIO = usuario.ID_USUARIO
inner join RUTINA_EJERCICIO on CLIENTE_RUTINA.ID_RUTINA = RUTINA_EJERCICIO.ID_RUTINA
inner join EJERCICIO on RUTINA_EJERCICIO.ID_EJERCICIO = EJERCICIO.ID_EJERCICIO
inner join rutina on RUTINA_EJERCICIO.ID_RUTINA = RUTINA.ID_RUTINA
order by nombreUsuario;

--CURSOR
DECLARE
  CURSOR usuarios_cursor IS
    SELECT * FROM USUARIO;
  usuario_record USUARIO%ROWTYPE;
BEGIN
  OPEN usuarios_cursor;
  LOOP
    FETCH usuarios_cursor INTO usuario_record;
    EXIT WHEN usuarios_cursor%NOTFOUND;
    -- Do something with the usuario_record.
  END LOOP;
  CLOSE usuarios_cursor;
END;

--PROCEDIMIENTO ALMACENADO 

CREATE OR REPLACE PROCEDURE insert_usuario (
  p_nombre USUARIO.NOMBRE%TYPE,
  p_apellido USUARIO.APELLIDO%TYPE,
  p_edad USUARIO.EDAD%TYPE,
  p_peso USUARIO.PESO%TYPE,
  p_altura USUARIO.ALTURA%TYPE,
  p_objetivo USUARIO.OBJETIVO%TYPE
) AS
BEGIN
  INSERT INTO USUARIO (NOMBRE, APELLIDO, EDAD, PESO, ALTURA, OBJETIVO)
  VALUES (p_nombre, p_apellido, p_edad, p_peso, p_altura, p_objetivo);
END;

--TRIGGER

CREATE OR REPLACE TRIGGER actualizar_num_entrenamientos_usuario
AFTER INSERT ON CLIENTE_RUTINA
FOR EACH ROW
BEGIN
  UPDATE USUARIO
  SET NUM_ENTRENAMIENTOS = NUM_ENTRENAMIENTOS + 1
  WHERE ID_USUARIO = :NEW.ID_USUARIO;
END;

--PAQUETE ESQUELETO

CREATE OR REPLACE PACKAGE gym_package AS
  FUNCTION obtener_usuario (p_id_usuario USUARIO.ID_USUARIO%TYPE)
    RETURN USUARIO%ROWTYPE;

  PROCEDURE agregar_seguidor (p_id_usuario USUARIO.ID_USUARIO%TYPE, p_num_seguidores USUARIO.NUM_SEGUIDORES%TYPE);

  PROCEDURE agregar_siguiendo (p_id_usuario USUARIO.ID_USUARIO%TYPE, p_num_siguiendo USUARIO.NUM_SIGUIENDO%TYPE);
END gym_package;

--PAQUETE CUERPO

CREATE OR REPLACE PACKAGE BODY gym_package AS
  FUNCTION obtener_usuario (p_id_usuario USUARIO.ID_USUARIO%TYPE)
    RETURN USUARIO%ROWTYPE
  AS
    usuario_result USUARIO%ROWTYPE;
  BEGIN
    SELECT * INTO usuario_result
    FROM USUARIO
    WHERE ID_USUARIO = p_id_usuario;
    RETURN usuario_result;
  END obtener_usuario;

  PROCEDURE agregar_seguidor (p_id_usuario USUARIO.ID_USUARIO%TYPE, p_num_seguidores USUARIO.NUM_SEGUIDORES%TYPE)
  AS
  BEGIN
    UPDATE USUARIO
    SET NUM_SEGUIDORES = NUM_SEGUIDORES + p_num_seguidores
    WHERE ID_USUARIO = p_id_usuario;
  END agregar_seguidor;

  PROCEDURE agregar_siguiendo (p_id_usuario USUARIO.ID_USUARIO%TYPE, p_num_siguiendo USUARIO.NUM_SIGUIENDO%TYPE)
  AS
  BEGIN
    UPDATE USUARIO
    SET NUM_SIGUIENDO = NUM_SIGUIENDO + p_num_siguiendo
    WHERE ID_USUARIO = p_id_usuario;
  END agregar_siguiendo;
END gym_package;





   





