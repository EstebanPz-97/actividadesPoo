// See https://aka.ms/new-console-template for more information
using Actividad5.Controllers;
using Actividad5.Models;
using Actividad5.Views.Productos;


ProductoController controller = new ProductoController(new CrearProducto());
controller.Crear("5", "papas margaritas", Tienda.Build("4","la esquina","cll 188 # 15"));

