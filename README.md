# Proyecto Heladería VB.NET
Aplicación en Visual Basic (2010) que consulta una base de datos sobre helados, utilizando MariaDB arrancada través de XAMPP.
---
## 1. Arquitectura de Datos
- **Motor:** MySQL 8.0
- **Relación:** 1:N (Categoría a Productos)
- **Integridad:** Uso de Inner Joins para informes combinados.

## 2. Configuración
- **IDE:** Visual Studio
- **Driver:** MySQL Connector/NET
- **DLL's necesarias:** `MySql.Data.dll` y `System.Windows.Forms.DataVisualization.dll`
- **Requisito:** Base de datos `sorveteria_projeto.sql`.


## 3. Ejecución y Funcionalidades
- **Randomization:** Algoritmo `Random.Next()` para sorteos.
- **Visualización:** Control `Chart` con soporte 3D.
- **Pruebas:** Módulo de pruebas unitarias y caja negra automatizado.

## 4. Guía de Usuario
1. Definir rango. (Mínimo y máximo)
2. Sortear ID.
3. Visualizar ficha técnica.
4. Exportar reportes legales en TXT.
