# IngenieriaSoftware
Proyecto Ingeniería de Software 2, Venta de Automóviles (C# .NET FRAMEWORK).

## Descripcion

Proyecto destinado al manejo de la Lógica necesaria en un comercio de automóviles, el fin de este proyecto es la aplicación 
de patrones arquitectónicos y de diseño.

Patrones Utilizados:

- **MVC** - `Modelo Vista Controlador, como patrón del proyceto en General, separando los repositorios de clases en 3 capas: Modelo, Vista, Controlador`
- **Observer** - `Patrón implementado en el módulo de Fábrica, los departamentos se suscribiran o No, dependiendo del tipo de Orden creada`
- **Builder** - `Patrón utilizado para formar el objecto automóvil, este es capás de construir distintos tipos de automóviles, de forma personalizable`

## Prerrequisitos

1. Base de Datos: Se debe utilizar una base de datos MYSQL, con el esquema necesario para el sistema. La instalación se hará posteriormente.

2. SO Windows: Gracias a que se compilan todas las dependencias necesarias, no es necesario nada más.

## Instalación

1. Asegurese de tener [Docker Instalado](https://docs.docker.com/docker-for-windows/install/) en tu sistema, y despues clona este repositorio.

2. Navega en tu terminal hasta el directorio con el repositorio de Este proyecto clonado, despliega los contenedores correspondientes mediante el comando `docker-compose up -d`.
El contenedor mysql construido para nuestro proyecto está expuesto en el siguiente puerto:

- **mysql** - `:3306`

## Uso

Posterior a la instalación de la base de datos, se ejecturá un script en automático para la creación del esquema necesario para el sistema.
Una vez terminados los pasos anteriores, se debe proceder a ejecutar el archivo ejecutable (.exe). Situado en el siguiente Directorio:

`\Views\Views\bin\Debug\Views.exe`
