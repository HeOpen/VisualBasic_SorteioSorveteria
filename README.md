# 🍦 Heladería Sorteo & Inventario

![VB.NET](https://img.shields.io/badge/VB.NET-512BD4?style=for-the-badge&logo=visual-studio&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white)

> Sistema de gestión de inventario con sorteo aleatorio y motor de pruebas automatizado.

### 🚀 Funcionalidades
- **Sorteo Inteligente:** Algoritmo de generación aleatoria para selección de productos.
- **Gráficos Dinámicos:** Visualización de stock en 2D/3D.
- **QA Testing:** Módulo integrado de 15 pruebas de calidad.

### 📸 Capturas
| Formulario Principal | Informes y Gráficos |
|---|---|
<img width="924" height="468" alt="1_Form1" src="https://github.com/user-attachments/assets/98d7ab80-4635-4250-bd2a-aa2fab5d58f5" />
<img width="849" height="484" alt="2_ComboBoxHistorial" src="https://github.com/user-attachments/assets/ba030edc-b57e-4180-af0b-24a1ae5a6501" />
<img width="1620" height="1045" alt="3_ConsultaSorteo" src="https://github.com/user-attachments/assets/412119fc-cb34-4931-8d0a-ba732d2f76ef" />
<img width="1611" height="1048" alt="4_SelectALL" src="https://github.com/user-attachments/assets/196cedff-c93d-4f32-8bda-ae646f824110" />
<img width="1614" height="1053" alt="5_Grafico3D" src="https://github.com/user-attachments/assets/58e3d00f-fc51-4c73-91ef-88e804102d8f" />
<img width="1386" height="1015" alt="6_Report_TXT" src="https://github.com/user-attachments/assets/d54256fd-c652-4a09-b684-87d25c587101" />

### 🛠️ Instalación
1. Clona el repositorio.
2. Importa el archivo `db/schema.sql` en tu MySQL.
3. Ejecuta el instalador en `setup/setup.exe`.
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
