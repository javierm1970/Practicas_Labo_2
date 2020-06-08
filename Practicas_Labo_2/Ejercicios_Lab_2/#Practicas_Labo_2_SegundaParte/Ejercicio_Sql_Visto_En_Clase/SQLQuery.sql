SELECT *
FROM dbo.Alumnos

-- -----------------------------------
SELECT nombre 
FROM dbo.Alumnos

-- ---------------------------------
SELECT * 
FROM dbo.Alumnos
where nombre LIKE '%a%'

-- ---------------------------------
SELECT * 
FROM dbo.Profesores
where apellido LIKE 'd%'

-- ---------------------------------
SELECT * 
FROM dbo.Alumnos
where legajo = 1642070223999

-- ---------------------------------
UPDATE dbo.Alumnos 
SET nombre = 'Javier', apellido = 'Magdaleno'
WHERE legajo = 1642070223999

SELECT * from Alumnos
where legajo = 1642070223999

-- ---------------------------------
DELETE dbo.Alumnos 
WHERE legajo = 1642070223999

SELECT * 
FROM Alumnos
WHERE legajo = 1642070223999

-- ---------------------------------
SELECT Alumnos.nombre + ' ' + apellido 'Apellido y Nombre' 
FROM Alumnos
INNER JOIN Cursos 
ON Alumnos.curso = Cursos.id

WHERE Cursos.nombre = '2ºC-1'
-- ---------------------------------
SELECT Alumnos.nombre + ' ' + Alumnos.apellido 'Ape y Nom Alumno',
	Cursos.nombre 'Nom Curso', Profesores.nombre + ' '+ Profesores.apellido 'Ape y Nom Profesor'
FROM Alumnos
INNER JOIN Cursos 
ON Alumnos.curso = Cursos.id 

INNER JOIN Profesores
ON Cursos.profesor = Profesores.legajo

WHERE Cursos.nombre = '2ºC-1'

