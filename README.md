# Sistema de Gestión de Restaurante

Aplicación de escritorio desarrollada en C# y Windows Forms para registrar órdenes de comida y calcular el total de consumo de un restaurante.

## Descripción

Este proyecto implementa una interfaz gráfica para seleccionar productos del menú, indicar cantidades y agregarlos a una orden. La aplicación calcula el importe de cada producto y permite obtener el total acumulado de la orden.

El proyecto incluye recursos visuales para diferentes productos del menú, como hamburguesas, pizza, tacos, ensalada, pollo, papas fritas, café, pastel y pancakes.

## Funcionalidades implementadas

- Selección de productos del menú.
- Registro de cantidades mediante una ventana de entrada.
- Agregado de productos a la orden.
- Cálculo del subtotal por producto.
- Cálculo del total de la orden.
- Visualización de los productos en una tabla.
- Limpieza de la orden para iniciar una nueva.
- Interfaz gráfica con formularios y recursos visuales.

## Módulos

### Restaurante

El formulario principal permite seleccionar productos, indicar cantidades y revisar los elementos agregados a la orden.

### Facturación

El proyecto incluye un formulario independiente para facturación, preparado para futuras funcionalidades de generación o consulta de facturas.

## Tecnologías

- C#
- .NET Framework 4.7.2
- Windows Forms
- Visual Studio
- Microsoft.VisualBasic para la captura de cantidades

## Estructura principal

- `frmRestaurante.cs`: lógica del formulario principal y gestión de órdenes.
- `frmRestaurante.Designer.cs`: componentes visuales del formulario.
- `frmFactura.cs`: formulario destinado a la facturación.
- `frmFactura.Designer.cs`: componentes visuales del formulario de facturación.
- `Program.cs`: punto de entrada de la aplicación.
- `Resources/`: imágenes y recursos del menú.
- `Proyecto_Restaurante.sln`: solución de Visual Studio.
- `Proyecto_Restaurante.csproj`: configuración del proyecto.

## Requisitos

- Windows.
- Visual Studio compatible con .NET Framework 4.7.2.
- .NET Framework 4.7.2 instalado.

## Ejecución

1. Clona el repositorio:

   ```bash
   git clone https://github.com/Jenncy/Proyecto_Restaurante.git
   ```

2. Abre `Proyecto_Restaurante.sln` en Visual Studio.

3. Selecciona la configuración `Debug` o `Release`.

4. Compila la solución.

5. Ejecuta la aplicación con `F5` o mediante el botón **Iniciar**.

## Flujo de uso

1. Selecciona un producto del menú.
2. Ingresa la cantidad solicitada.
3. Revisa el producto agregado en la tabla de la orden.
4. Presiona el botón para calcular el total.
5. Utiliza la opción de nueva orden para limpiar la tabla y comenzar otra.

## Estado del proyecto

Proyecto académico funcional en desarrollo. El módulo principal de órdenes y cálculo de totales está implementado; el formulario de facturación está preparado para ampliarse.

## Mejoras futuras

- Permitir editar o eliminar productos de una orden.
- Agregar más productos y precios configurables.
- Validar cantidades y evitar entradas inválidas.
- Calcular impuestos, descuentos y cambio.
- Completar el módulo de facturación.
- Guardar órdenes en una base de datos.
- Generar comprobantes de compra.
- Separar la lógica de negocio de la interfaz gráfica.

## Autor

Proyecto desarrollado como práctica académica de programación de aplicaciones de escritorio.
