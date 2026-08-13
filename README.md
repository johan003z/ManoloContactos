# ManoloContactos

Aplicación web desarrollada con ASP.NET Core 10 para la gestión de contactos, con autenticación de usuarios y persistencia de información mediante PostgreSQL.
El proyecto fue desarrollado como parte de una prueba técnica de programación.

## Aplicación

https://manolocontactos-production.up.railway.app/

## Tecnologías utilizadas

* .NET 10
* ASP.NET Core
* C#
* Entity Framework Core
* ASP.NET Core Identity
* PostgreSQL
* Npgsql
* Razor Pages
* HTML5
* CSS3
* Git
* GitHub
* Railway

## Funcionalidades

* Registro de usuarios
* Inicio y cierre de sesión
* Autenticación mediante ASP.NET Core Identity
* Gestión de contactos
* Persistencia de datos mediante PostgreSQL
* Gestión de la base de datos mediante Entity Framework Core
* Aplicación automática de migraciones al iniciar la aplicación
* Despliegue en Railway

## Uso de la aplicación

- Ingresar a la aplicación mediante el enlace de producción
- Dirigirse a la sección "Registrar" para crear un usuario
- Iniciar sesión con las credenciales registradas
- Acceder a la sección de contactos para consultar y gestionar los registros

## Arquitectura

La aplicación utiliza ASP.NET Core como framework principal y PostgreSQL como sistema de gestión de base de datos.

```text
Usuario
   |
   v
Aplicación ASP.NET Core
   |
   +-- ASP.NET Core Identity
   |
   +-- Gestión de contactos
   |
   +-- Entity Framework Core
             |
             v
        PostgreSQL
```

En producción, la aplicación y la base de datos se ejecutan mediante Railway.

```text
GitHub
   |
   v
Railway
   |
   +-- ManoloContactos (.NET 10)
   |
   +-- PostgreSQL
```

## Estructura del proyecto

```text
ManoloContactos/
├── Areas/
│   └── Identity/
│       └── Pages/
│           └── Account/
├── Controllers/
├── Data/
├── Models/
├── Views/
├── Migrations/
├── wwwroot/
├── Program.cs
├── appsettings.json
└── ManoloContactos.csproj
```

## Requisitos

* .NET SDK 10
* PostgreSQL
* Git

## Instalación y ejecución local

### 1. Clonar el repositorio

```bash
git clone <repositorio>
```

### 2. Entrar al proyecto

```bash
cd ManoloContactos
```

### 3. Restaurar las dependencias

```bash
dotnet restore
```

### 4. Configurar PostgreSQL

Configurar la cadena de conexión en `appsettings.json` de acuerdo con la base de datos local.

Ejemplo:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=ManoloContactos;Username=usuario;Password=contraseña"
  }
}
```

Las credenciales utilizadas en producción se configuran mediante variables de entorno y no se almacenan en el repositorio.

### 5. Aplicar las migraciones

```bash
dotnet ef database update
```

La aplicación también está configurada para aplicar automáticamente las migraciones pendientes al iniciar.

### 6. Ejecutar la aplicación

```bash
dotnet run
```

La aplicación estará disponible en la dirección indicada por ASP.NET Core en la terminal.

## Despliegue en Railway

El proyecto fue desplegado utilizando Railway.

La configuración de producción utiliza dos servicios:

* ManoloContactos: aplicación ASP.NET Core 10
* PostgreSQL: base de datos de producción

La conexión entre ambos servicios se realiza mediante variables de entorno de Railway.

La aplicación utiliza la variable:

```text
ConnectionStrings__DefaultConnection
```

para obtener la cadena de conexión de PostgreSQL en producción.

Las credenciales de la base de datos no se almacenan directamente en el código fuente.

### Migraciones en producción

La aplicación ejecuta las migraciones pendientes de Entity Framework Core al iniciar.

Esto permite crear y actualizar las tablas necesarias automáticamente durante el despliegue.

## Decisiones tomadas durante el desarrollo

### ASP.NET Core

Se utilizó ASP.NET Core como framework principal debido a su integración con C#, Entity Framework Core y ASP.NET Core Identity, además de proporcionar una estructura organizada para el desarrollo de aplicaciones web.

### ASP.NET Core Identity

Se utilizó ASP.NET Core Identity para implementar el sistema de autenticación, aprovechando las funcionalidades proporcionadas por el framework para la gestión de usuarios y autenticación.

### Entity Framework Core

Se utilizó Entity Framework Core para gestionar la comunicación entre la aplicación y PostgreSQL y para administrar los cambios en la estructura de la base de datos mediante migraciones.

### PostgreSQL

Se seleccionó PostgreSQL como sistema de gestión de base de datos por su compatibilidad con .NET mediante Npgsql y por permitir utilizar una solución consistente tanto en desarrollo local como en producción.

### Railway

Se seleccionó Railway para el despliegue debido a que permite ejecutar la aplicación ASP.NET Core y disponer de una instancia de PostgreSQL dentro del mismo proyecto.

La conexión entre ambos servicios se gestiona mediante variables de entorno, evitando almacenar credenciales directamente en el código fuente.

### Git y GitHub

Se utilizó Git para el control de versiones y GitHub como repositorio del código fuente. El repositorio también se utiliza como origen del despliegue de la aplicación en Railway.

## Limitaciones

* El proyecto fue desarrollado como parte de una prueba técnica, por lo que se priorizaron las funcionalidades principales solicitadas
* La interfaz puede recibir mejoras adicionales de diseño y experiencia de usuario
* Algunas validaciones y medidas de seguridad podrían ampliarse para un entorno de producción de mayor escala
* El proyecto depende de las variables de entorno configuradas en el entorno de ejecución
* Para una aplicación de mayor escala sería recomendable implementar pruebas automatizadas, logging más avanzado y una estrategia de manejo de errores más completa

## Estado del proyecto

Proyecto finalizado y desplegado en Railway.
https://manolocontactos-production.up.railway.app/

## Autor

Johan Aguilar
