# ISIL Proyecto Final - Fugu
Esta es una aplicacion para crear y compartir recetas online.
Para este proyecto se ha hecho uso de .NET Core RC2.
Se ha hecho uso del enfoque Code First en el cual nos enfocamos en crear las entidades usando el framework "Entity Framework", creamos "Migrations" a partir de nuestros modelos y al correr las migraciones se creara la base de datos con el esquema definido en nuestros modelos.

Fuentes:

- [https://docs.efproject.net/en/latest/platforms/aspnetcore/new-db.html](https://docs.efproject.net/en/latest/platforms/aspnetcore/new-db.html)
- [https://msdn.microsoft.com/en-us/data/jj591621.aspx](https://msdn.microsoft.com/en-us/data/jj591621.aspx)

##Curso
- Desarrollo de Software II

##Integrantes
- Robinson Kent Villegas Rojas

###Requerimientos
Para poder ejecutar este proyecto en tu PC hay unos prerequisitos:

- Necesitas instalar el .NET Core SDK, puedes hacerlo desde este [enlace](https://www.microsoft.com/net/core#windows).
- Tener Visual Studio 2015 (Recomendado) o algun editor de texto con [Omnisharp](https://github.com/OmniSharp/omnisharp-roslyn) instalado

###Instalación
- Abrir la consola de comandos y ejecutar (Esto correrrá las migraciones existentes y se creara la base de datos): 
```
dotnet ef database update 
```

- En el caso que no se este utilizando visual studio:
```
dotnet dnx web
```

###Mejoras y/o Bugs Encontrados (Estado Actual)
- Implementar Autorizacion y Atentificacion
- Arreglar campos de fecha en las tablas (Timestamp)
- Mejorar modelamiento de Entidades
- Crear Migrations para llenar información de prueba (Seeds)