# GitHub Activity CLI

## Overview

Esta es una sencilla aplicación de línea de comandos (CLI) que te permite obtener la actividad reciente de un usuario de GitHub y mostrarla directamente en tu terminal. Este proyecto es una excelente manera de practicar tus habilidades de programación, incluyendo el trabajo con APIs, el manejo de datos JSON y la construcción de aplicaciones CLI básicas.

## Requisitos

La aplicación debe ejecutarse desde la línea de comandos, aceptar el nombre de usuario de GitHub como un argumento, obtener la actividad reciente del usuario utilizando la API de GitHub y mostrarla en la terminal. El usuario debe poder:

* **Proporcionar el nombre de usuario de GitHub como un argumento** al ejecutar la CLI.

    ```bash
    github-activity <nombre_de_usuario>
    ```

    Ejemplo:

    ```bash
    github-activity kamranahmedse
    ```

* **Obtener la actividad reciente del usuario especificado** utilizando la API de GitHub. Puedes utilizar el siguiente endpoint para obtener la actividad del usuario:

    ```
    [https://api.github.com/users/](https://api.github.com/users/)<nombre_de_usuario>/events
    ```

    Ejemplo:

    ```
    [https://api.github.com/users/kamranahmedse/events](https://api.github.com/users/kamranahmedse/events)
    ```

* **Mostrar la actividad obtenida en la terminal** en un formato legible.

    **Salida de ejemplo:**

    ```
    - Pushed 3 commits to kamranahmedse/developer-roadmap
    - Opened a new issue in kamranahmedse/developer-roadmap
    - Starred kamranahmedse/developer-roadmap
    - ...
    ```

* **Manejar errores de forma elegante**, como nombres de usuario inválidos o fallos en la API.

* **Utilizar el lenguaje de programación de tu elección** para construir este proyecto.

* **No utilizar librerías o frameworks externos** para obtener la actividad de GitHub.

## Cómo utilizar

1.  **Asegúrate de tener el entorno de ejecución** del lenguaje de programación que elegiste instalado en tu sistema.
2.  **Guarda el código de la aplicación** en un archivo (por ejemplo, `github_activity.py` si usas Python, o `github_activity.js` si usas Node.js).
3.  **Abre tu terminal o línea de comandos.**
4.  **Navega hasta el directorio** donde guardaste el archivo de la aplicación.
5.  **Ejecuta la aplicación** pasando el nombre de usuario de GitHub como argumento:

    ```bash
    # Ejemplo si usaste Python
    python github_activity.py <nombre_de_usuario>

    # Ejemplo si usaste Node.js
    node github_activity.js <nombre_de_usuario>
    ```

    Reemplaza `<nombre_de_usuario>` con el nombre de usuario de GitHub del que deseas ver la actividad.

## Recursos

Puedes aprender más sobre la API de GitHub aquí: [https://docs.github.com/en/rest](https://docs.github.com/en/rest)

## Notas

* Esta aplicación se conecta directamente a la API de GitHub sin utilizar ninguna librería externa para la gestión de la red o el manejo de JSON.
* La salida muestra un resumen básico de los eventos recientes. Puedes personalizar la forma en que se muestra la información según tus preferencias.
* Es importante manejar posibles errores de red y respuestas inesperadas de la API para proporcionar una mejor experiencia al usuario.

https://roadmap.sh/projects/github-user-activity
