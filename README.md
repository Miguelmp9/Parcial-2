Este proyecto es una API REST desarrollada con Spring Boot que permite gestionar categorías y productos para una tienda ficticia llamada ForCookies. La arquitectura se basa en principios de programación orientada a objetos (POO) y buenas prácticas de desarrollo backend.

🚀 Tecnologías Utilizadas
Java 17+

Spring Boot

Maven

JPA / Hibernate

H2 Database (o configurable a MySQL/PostgreSQL)

DTO Pattern

Controller-Service-Repository architecture

RESTful API

📁 Estructura del Proyecto
bash
Copiar
Editar
ForCookies-APIRest-POO-developer/
├── webapi/
│   ├── src/main/java/com/forcookies/webapi/
│   │   ├── controller/            # Controladores REST
│   │   ├── payload/               # Clases auxiliares como DTOs y responses
│   │   ├── service/               # Interfaces y servicios para lógica de negocio
│   │   ├── entity/                # Entidades JPA (si están presentes)
│   │   └── ForCookiesWebApiApplication.java
│   └── src/main/resources/
│       └── application.properties
🧠 Funcionalidades Principales
📂 Gestión de Categorías

GET /categoria → Lista todas las categorías.

POST /categoria/crear → Crea una nueva categoría.

DELETE /categoria/delete?delCateogoriaId=ID → Elimina una categoría por ID.

📦 (Opcional) Gestión de Productos

(Módulo pendiente si no está implementado aún)

📦 Instalación y Ejecución
Clona el repositorio:

bash
Copiar
Editar
git clone https://github.com/tu-usuario/ForCookies-APIRest-POO-developer.git
Abre el proyecto en tu IDE (IntelliJ, Eclipse, VS Code, etc.).

Asegúrate de tener configurado Java 17+ y Maven.

Ejecuta la aplicación:

bash
Copiar
Editar
mvn spring-boot:run
Accede a la API desde http://localhost:8080

🧪 Ejemplos de Uso
Crear una categoría (POST)
bash
Copiar
Editar
POST /categoria/crear
Content-Type: application/json

{
  "nombre": "Bebidas",
  "descripcion": "Categoría para productos líquidos"
}
Obtener todas las categorías (GET)
bash
Copiar
Editar
GET /categoria
Eliminar una categoría (DELETE)
sql
Copiar
Editar
DELETE /categoria/delete?delCateogoriaId=1
💡 Notas
Este proyecto fue construido siguiendo buenas prácticas de POO.

Usa DTOs para separar entidades del modelo de presentación.

Puedes migrar fácilmente entre bases de datos cambiando la configuración en application.properties.

👨‍💻 Autor
Desarrollado por el equipo de ForCookies con enfoque educativo y profesional.
