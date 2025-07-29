# 📚 Book Manager

**Book Manager** es una aplicación de consola desarrollada en C# que permite gestionar libros de manera sencilla. Este proyecto es ideal para prácticas de programación orientada a objetos, manejo de listas, clases y estructuras básicas de datos.

---

## 🚀 Características

### 📚 Gestión de Libros
- Cada libro contiene:
  - `Título`: Nombre del libro.
  - `Autor`: Nombre del autor.
  - `Año de publicación`: Año en que se publicó.
- Método `MostrarInformacion()` para imprimir la información completa del libro.

### 🧑 Gestión de Personas
- Cada persona tiene:
  - `Nombre`, `Apellido`, `Edad`.
- Método `Saludar()` que imprime un saludo personalizado.

### 🗄️ Gestión de Estantes
- Cada estante contiene:
  - `Número de estante`, `Capacidad máxima`, y una lista de libros.
- Método `MostrarContenido()` que imprime el detalle del estante y los libros que contiene.

### 🔄 Lógica de Ejecución
- Se instancian 3 libros, 2 personas y 1 estante directamente en código.
- Se muestra en consola:
  - Información de los libros.
  - Contenido del estante.
  - Saludo de las personas.

---

## 🛠️ Tecnologías

- **Lenguaje:** C#
- **Framework:** .NET 6 / .NET Core
- **Tipo de aplicación:** Consola

---

## 📦 Estructura del Proyecto

```
📁 GestorLibros/
├── 📁 Models/
│   ├── Book.cs
│   ├── Person.cs
│   └── Shelf.cs
├── Program.cs
├── README.md
├── .gitignore
└── GestorLibros.csproj
```

---

## ▶️ Cómo Ejecutar

1. Clona el repositorio:

   ```bash
   git clone https://github.com/kevindoblea1/book-manager-git.git
   cd book-manager-git
   ```

2. Compila y ejecuta:

   ```bash
   dotnet build
   dotnet run
   ```

---

## 📌 Notas

- Asegúrate de tener instalado .NET SDK 6 o superior.

---

## 📄 Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo [LICENSE](LICENSE) para más información.

---

## 🤝 Autor

Desarrollado por [Kevin Alvarenga](https://www.linkedin.com/in/kevindoblea/) - README.md cortesía de OpenIA.
