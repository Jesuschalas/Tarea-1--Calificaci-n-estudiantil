📘 Sistema de Cálculo de Notas en C#
📌 Descripción

Este proyecto consiste en una aplicación de escritorio desarrollada en C# con Windows Forms, que permite ingresar cuatro notas académicas, calcular el promedio, y determinar el estado académico del estudiante según las reglas de evaluación vigentes.

El sistema informa automáticamente si el estudiante:

Aprueba directamente

Aprueba por completivo

Aprueba por extraordinario

Reprueba

🛠️ Tecnologías Utilizadas

Lenguaje: C#

Framework: .NET – Windows Forms (WinForms)

IDE: Visual Studio

⚙️ Funcionamiento del Sistema

Se ingresan cuatro notas.

Se calcula el promedio general.

Según el resultado, el sistema habilita automáticamente los campos necesarios.

El estado del estudiante se muestra en pantalla mediante mensajes claros.

📐 Reglas de Evaluación

Promedio > 69 → ✅ Aprobado

Promedio ≤ 69 → Pasa a Completivo

🧮 Cálculo del Completivo

50% del promedio

50% de la nota del completivo

Resultado del completivo:

69 → ✅ Aprobado por Completivo

≤ 69 → Pasa a Extraordinario

🧮 Cálculo del Extraordinario

30% del promedio

70% de la nota del extraordinario

Resultado del extraordinario:

69 → ✅ Aprobado por Extraordinario

≤ 69 → ❌ Reprobador

🖼️ Escenarios de Ejecución del Sistema

📷 Escenario 1: Formulario vacío
El sistema inicia sin datos ingresados y con los campos de completivo y extraordinario deshabilitados.
![alt](https://github.com/Jesuschalas/Tarea-1--Calificaci-n-estudiantil/blob/9f0295e2c2b1d2f6845f30703705299fe35d5949/Captura%20de%20pantalla%202026-01-28%20230551.png)
📷 Escenario 2: Aprobado directo
Se ingresan las cuatro notas y el promedio es mayor a 69, mostrando el mensaje "Aprobado".
https://github.com/Jesuschalas/Tarea-1--Calificaci-n-estudiantil/blob/9f0295e2c2b1d2f6845f30703705299fe35d5949/Captura%20de%20pantalla%202026-01-28%20230653.png
📷 Escenario 3: Promedio reprobado
El promedio es menor o igual a 69 y se habilita el campo para ingresar la nota del completivo.
https://github.com/Jesuschalas/Tarea-1--Calificaci-n-estudiantil/blob/9f0295e2c2b1d2f6845f30703705299fe35d5949/Captura%20de%20pantalla%202026-01-28%20232057.png
📷 Escenario 4: Aprobado por completivo
El estudiante aprueba luego de calcular la nota final del completivo.
https://github.com/Jesuschalas/Tarea-1--Calificaci-n-estudiantil/blob/9f0295e2c2b1d2f6845f30703705299fe35d5949/Captura%20de%20pantalla%202026-01-28%20232230.png
📷 Escenario 5: Reprobado en completivo
El estudiante no alcanza la nota mínima en el completivo y se habilita el campo de extraordinario.
https://github.com/Jesuschalas/Tarea-1--Calificaci-n-estudiantil/blob/9f0295e2c2b1d2f6845f30703705299fe35d5949/Captura%20de%20pantalla%202026-01-28%20232320.png
📷 Escenario 6: Aprobado por extraordinario
El estudiante aprueba tras calcular la nota final del extraordinario.

📷 Escenario 7: Reprobado definitivo
El estudiante no alcanza la nota mínima en ninguna de las evaluaciones y el sistema muestra el mensaje "Reprobador".

▶️ Uso o Ejecución

Abrir el proyecto en Visual Studio.

Ejecutar el proyecto presionando F5.

Ingresar las cuatro notas.

Presionar el botón Calcular.

Si aplica, ingresar la nota del Completivo o Extraordinario.

Visualizar el estado académico del estudiante.

🎓 Contexto Académico

Nivel: Secundaria Técnico Profesional

Módulo Formativo: Desarrollo de Aplicaciones y Sistemas de Información

Curso / Sección: 5to D1

Año Escolar: 2025–2026

👤 Autor

Nombre del estudiante:
Jesus Chalas

💡 Nota Final

Este proyecto fue desarrollado con fines académicos, aplicando conocimientos de programación estructurada, validación de datos y lógica condicional en C#.
