#Ejercicio tienda

Objetivos:
1. Aplicar principios SOLID 
2. Incrementar la modularidad del programa
3. aplicar operaciones CRUD

Funciones de los archivos:
Program.cs - Inicializa el objeto controller el cual ejecuta los métodos que se declararon en service
TiendaModel - Declara las variables que se van a emplear a lo largo del programa como nombre, apellidos, correo, contraseña, sucursal, tipo de eempleado y turno
TiendaController - Inicializa el objeto TiendaService, en donde se encuentran construidos los métodos
TiendaService - Contiene los métodos necesarios para llevar a cabo operaciones básicas de tipo CRUD
TiendaRepository - Contiene una coleccion observable de objetos iterables, se creo con la finalidad de asignar un espacio en la memoria
                   para almacenar los datos que se generan en TiendaService.cs

sucursales, turno y tipo de empleado, son archivos enum en donde se almacena un listado con la ubicación de la sucursal, el turno y el tipo de empleado. se emplearon 
en conjunto con TiendaService para la construcción del proyecto.

Notas personales:
Se requiere mejorar algunos aspectos del código, ya que algunos archivos no cuentan con la validación de los datos, lo que podría generar que el código se rompa durante la operación.
Se requiere mejorar la experiencia del usuario, ya que varias pantallas se encuentran saturadas de texto

