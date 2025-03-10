# Sistema de Ventas - TecniCelular
Descripción
TecniCelular es un sistema de ventas diseñado para gestionar la comercialización de celulares y accesorios. Permite registrar clientes, administrar productos, gestionar compras y generar reportes de ventas.

El sistema está desarrollado en C# (Windows Forms) con una base de datos en SQL Server para almacenar la información.

## Características
1. Módulo de Autenticación
Inicio de sesión seguro con validación de usuarios en la base de datos.
Gestión de roles de usuario (Administrador y Vendedor).
2. Gestión de Clientes
Registro y modificación de clientes.
Búsqueda por nombre o número de identificación.
Historial de compras de cada cliente.
3. Administración de Productos
Alta, baja y modificación de productos.
Control de stock y actualización automática después de cada venta.
Categorización de productos (celulares, accesorios, combos).
4. Proceso de Ventas
Selección de cliente y productos.
Cálculo automático del total con impuestos incluidos.
Generación de facturas en formato PDF.
5. Reportes y Estadísticas
Reportes de ventas con filtros por fecha y cliente.
Exportación en PDF y Excel.
Visualización de ingresos y tendencias de ventas.

## Base de Datos (SQL Server)
Tablas Principales
Clientes: Almacena información de los clientes registrados.
Productos: Contiene el inventario de celulares y accesorios.
Ventas: Registra cada transacción de venta.
DetalleVenta: Relaciona las ventas con los productos vendidos.
Usuarios: Almacena las credenciales y roles del sistema.
Relaciones Clave
Un cliente puede realizar múltiples ventas.
Una venta puede incluir varios productos.
Cada producto pertenece a una categoría específica.
