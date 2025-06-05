Este es un proyecto desarrollado por nuestro equipo Forcookies como parte de nuestro proyecto parcial final. Creamos una API REST con Spring Boot para simular el backend de una tienda virtual llamada ForCookies, con el objetivo de practicar los conceptos de Programación Orientada a Objetos (POO), en base a los requerimientos que se nos dieron en la rubrica.


1-Diseño de APIs RESTful

Programación orientada a objetos y principios SOLID

Separación de responsabilidades (controladores, servicios, repositorios, DTOs)

Uso de herramientas reales del entorno Java y Spring

2-Herramientas y tecnologías que usamos
Herramienta	y para qué la usamos?
Java 17+	El lenguaje con el que desarrollamos todo
Spring Boot	Framework principal para crear la API
Spring Web	Nos permitió crear los controladores REST
Spring Data JPA	Para guardar y manejar datos fácilmente
Maven	Gestión de dependencias y estructura del proyecto
H2 Database	Base de datos en memoria (ideal para pruebas)
DTOs	Para transferir datos sin exponer todo el modelo

3-Estructura del proyecto
bash
Copiar
Editar
webapi/

├── controller/            # Aquí están los endpoints REST

├── service/               # Lógica de negocio (lo que hace realmente la app)

├── payload/               # DTOs y respuestas personalizadas

├── ForCookiesWebApiApplication.java  # Punto de entrada de Spring Boot

└── resources/
application.properties         # Configuración del proyecto

4- ¿Qué funcionalidades tiene?

Por ahora nos enfocamos en una parte básica pero muy importante: la gestión de categorías de productos. Lo hicimos bien organizado, dejando todo listo para seguir ampliando (productos, usuarios, carrito, etc.).

Endpoints disponibles
GET /categoria
Devuelve todas las categorías guardadas.

POST /categoria/crear
Permite crear una nueva categoría. Se envía un JSON con nombre y descripción.

DELETE /categoria/delete?delCateogoriaId={id}
Elimina la categoría según su ID.

5-¿Cómo lo ejecutás?
 Requisitos
Tener Java 17 o superior

Tener Maven instalado

Un IDE (como IntelliJ, Eclipse o VS Code)

6- Pasos para correrlo
Cloná el proyecto:

bash
Copiar
Editar
git clone https://github.com/tu-usuario/ForCookies-APIRest-POO-developer.git
Entrá a la carpeta:

bash
Copiar
Editar
cd ForCookies-APIRest-POO-developer/webapi
Corré la aplicación con Maven:

bash
Copiar
Editar
mvn spring-boot:run
Abrí el navegador y accedé a:

arduino
Copiar
Editar
http://localhost:8080
7- Probalo con Postman o curl
Crear categoría
http
Copiar
Editar
POST http://localhost:8080/categoria/crear
Content-Type: application/json

{
  "nombre": "Snacks",
  "descripcion": "Galletas, papas, y más"
}
Obtener categorías
http
Copiar
Editar
GET http://localhost:8080/categoria
Eliminar una categoría
http
Copiar
Editar
DELETE http://localhost:8080/categoria/delete?delCateogoriaId=1
8- Sobre la base de datos
Estamos usando H2, una base de datos en memoria que se reinicia cada vez que reiniciamos la app. ¡Súper práctica para pruebas!

Si querés ver los datos:

Accedé a:
http://localhost:8080/h2-console

Usá estos datos para conectarte:

yaml

Copiar

Editar

JDBC URL: jdbc:h2:mem:testdb

User:

Password: 
