# 🤖 Media Lab Digital Twin

Proyecto del gemelo digital para el Laboratorio Media Lab de la Universidad Autónoma de Occidente.

# 🤔 ¿Cómo empezar el proyecto?

1. Instalar y configurar el sistema de control de versiones [Git](https://git-scm.com/downloads) en su máquina.
2. Instalar la versión [Unity 2021.3.21f1](https://unity.com/releases/editor/whats-new/2021.3.21) desde Unity Hub con la opción **WebGL Build Support** activada.
3. Clonar el repositorio en su máquina.
4. Abrir una terminal/CMD/Bash/PowerShell en la carpeta del proyecto previamente clonada y ejecutar `git status` para comprobar que el proyecto se ha clonado correctamente.
5. Ejecutar el comando `git remote -v` para verificar que el proyecto apunta al directorio remoto ["https://github.com/Hector-f-Romero/Media-Lab-Digital-Twin"](https://github.com/Hector-f-Romero/Media-Lab-Digital-Twin).
6. Dentro de la terminal, ejecutar el comando `git switch -c {nombre}Branch` para crear una rama de forma local con su nombre y donde realizará todos sus cambios. Ejemplo `git switch -c hectorBranch`
7. Realizar sus aportes dentro del proyecto. Cuando desee guardar sus cambios en un commit, proceda a escribir `git add .` **DENTRO DE SU RAMA**.
8. Ejecuta `git commit -m "Mensaje del commit" -m "Mensaje opcional"`. Se debe utilizar el estandar y escribir los mensajes en inglés [convetional commits](https://www.conventionalcommits.org/en/v1.0.0/).
9. Suba sus cambios a su rama en primera instancia usando el comando `git push -u origin {nombre}Branch`. Ejemplo: `git push origin hectorBranch`. Después del primer push, se creará la rama en GitHub y podrá evitar escribir la bandera `-u` de aquí en adelante.
10. Verificar que sus proyectos se hayan subido correctamente a este [repositorio](https://github.com/Hector-f-Romero/Media-Lab-Digital-Twin).
11. En caso de querer combinar aportes entre dos o más personas, **SIEMPRE realizar los `git merge` en la rama `dev` en primera instancia.**

# 😺 Pasos a tener en cuenta al momento de empezar a trabajar

1. Siempre realizar el comando `git pull` para traer todos los cambios del repositorio remoto.
2. Para traer todos los cambios a la rama actual, realizar un `git pull origin dev` para pruebas preliminares o `git pull origin main` para traer todos los cambios ya probados y funcionales.
3. En caso de tener dificultades o problemas al realizar merges, escribir por el grupo o contactar a alguno de los miembros 😉

### Spatial Unity SDK Starter Template

A template to get you started building environments for Spatial. Read more here: https://docs.spatial.io
