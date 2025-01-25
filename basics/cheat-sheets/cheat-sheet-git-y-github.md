# Cheat Sheet de Git y GitHub

## Conceptos Básicos
- **Repositorio (Repo)**: Directorio donde se almacena tu proyecto y su historial de versiones.
- **Commit**: Guarda los cambios en el repositorio con un mensaje descriptivo.
- **Rama (Branch)**: Línea de desarrollo independiente dentro del repositorio.
- **Merge**: Combina dos ramas.
- **Clone**: Copia un repositorio remoto a tu máquina local.
- **Fork**: Copia un repositorio de otro usuario en GitHub a tu cuenta.
- **Pull Request (PR)**: Solicitud para fusionar cambios en un repositorio.

---

## Comandos Básicos de Git

### Configuración
- `git config --global user.name "Tu nombre"`: Establece tu nombre.
- `git config --global user.email "tu@email.com"`: Establece tu email.
- `git config --list`: Muestra la configuración actual.

### Iniciar un Repositorio
- `git init`: Inicializa un repositorio Git en el directorio actual.
- `git clone <url>`: Clona un repositorio remoto a tu máquina.

### Trabajar con Cambios
- `git status`: Muestra el estado de los archivos (modificados, no rastreados, etc.).
- `git add <archivo>`: Añade un archivo al área de preparación (staging).
- `git add .`: Añade todos los archivos modificados al staging.
- `git commit -m "Mensaje descriptivo"`: Guarda los cambios en el repositorio con un mensaje.
- `git commit --amend`: Modifica el último commit (útil para corregir mensajes o añadir cambios).

### Ramas (Branches)
- `git branch`: Lista todas las ramas locales.
- `git branch <nombre_rama>`: Crea una nueva rama.
- `git checkout <nombre_rama>`: Cambia a la rama especificada.
- `git checkout -b <nombre_rama>`: Crea y cambia a una nueva rama.
- `git merge <nombre_rama>`: Fusiona la rama especificada con la rama actual.
- `git branch -d <nombre_rama>`: Elimina una rama local.

### Historial y Cambios
- `git log`: Muestra el historial de commits.
- `git log --oneline`: Muestra el historial en una sola línea por commit.
- `git diff`: Muestra las diferencias entre archivos modificados y el último commit.
- `git show <commit_id>`: Muestra los cambios de un commit específico.

### Trabajar con Remotos
- `git remote -v`: Lista los repositorios remotos configurados.
- `git remote add origin <url>`: Añade un repositorio remoto.
- `git push origin <nombre_rama>`: Sube cambios al repositorio remoto.
- `git pull origin <nombre_rama>`: Descarga cambios del repositorio remoto y los fusiona.
- `git fetch`: Descarga cambios del repositorio remoto sin fusionarlos.

### Deshacer Cambios
- `git restore <archivo>`: Descarta cambios en un archivo modificado.
- `git reset --hard`: Descarta todos los cambios locales y vuelve al último commit.
- `git revert <commit_id>`: Crea un nuevo commit que deshace los cambios de un commit anterior.

---

## GitHub

### Trabajar con Repositorios Remotos
- **Fork**: Copia un repositorio de otro usuario a tu cuenta.
- **Clone**: Descarga un repositorio a tu máquina local.
- **Pull Request (PR)**: Solicita al propietario del repositorio que revise y fusione tus cambios.

### Comandos Útiles
- `git remote add upstream <url>`: Añade el repositorio original como remoto (útil después de hacer un fork).
- `git fetch upstream`: Descarga cambios del repositorio original.
- `git merge upstream/main`: Fusiona los cambios del repositorio original con tu rama principal.

### Issues y Pull Requests
- **Issues**: Reportar problemas o sugerencias en un repositorio.
- **Pull Request**: Proponer cambios y solicitar que se fusionen en el repositorio principal.

---

## Generar y Vincular una Llave SSH

### En Linux/macOS
1. Abre una terminal.
2. Genera una nueva llave SSH:
   ```bash
   ssh-keygen -t ed25519 -C "tu@email.com"