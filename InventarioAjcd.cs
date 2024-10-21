using System;
using System.Collections.Generic;

public class Inventario
{
    public static void Main(String[] args)
    {
        List<Tuple<int, string, int, double>> productos = InicializarInventario();
        int seleccion = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("----- Menú de Inventario -----");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Eliminar Producto");
            Console.WriteLine("3. Actualizar Producto");
            Console.WriteLine("4. Consultar Producto");
            Console.WriteLine("5. Listar Productos");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese su opción: ");
            seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    AgregarProducto(ref productos);
                    break;
                case 2:
                    EliminarProducto(ref productos);
                    break;
                case 3:
                    ActualizarProducto(ref productos);
                    break;
                case 4:
                    ConsultarProducto(productos);
                    break;
                case 5:
                    ConsultarProducto(productos);
                    Console.WriteLine("\nPulse una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Pulse una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        } while (seleccion != 6);
    }

    public static List<Tuple<int, string, int, double>> InicializarInventario()
    {
        return new List<Tuple<int, string, int, double>>();
    }

    public static void AgregarProducto(ref List<Tuple<int, string, int, double>> productos)
    {
        Console.Write("Ingrese el código del producto: ");
        int codigo = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        int cantidad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());

        productos.Add(new Tuple<int, string, int, double>(codigo, nombre, cantidad, precio));
        Console.WriteLine("Producto agregado con éxito.");
        Console.WriteLine("Pulse una tecla para continuar...");
        Console.ReadKey();
    }

    public static void EliminarProducto(ref List<Tuple<int, string, int, double>> productos)
    {
        if (productos.Count == 0)
        {
            Console.WriteLine("No hay productos en el inventario.");
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
            return;
        }

        Console.Write("Ingrese el código del producto a eliminar: ");
        int codigo = int.Parse(Console.ReadLine());

        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i].Item1 == codigo)
            {
                productos.RemoveAt(i);
                Console.WriteLine("Producto eliminado con éxito.");
                Console.WriteLine("Pulse una tecla para continuar...");
                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("Producto no encontrado.");
        Console.WriteLine("Pulse una tecla para continuar...");
        Console.ReadKey();
    }

    public static void ActualizarProducto(ref List<Tuple<int, string, int, double>> productos)
    {
        if (productos.Count == 0)
        {
            Console.WriteLine("No hay productos en el inventario.");
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
            return;
        }

        Console.Write("Ingrese el código del producto a actualizar: ");
        int codigo = int.Parse(Console.ReadLine());

        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i].Item1 == codigo)
            {
                Console.Write("Ingrese el nuevo nombre del producto: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese la nueva cantidad del producto: ");
                int cantidad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el nuevo precio del producto: ");
                double precio = double.Parse(Console.ReadLine());

                productos[i] = new Tuple<int, string, int, double>(codigo, nombre, cantidad, precio);
                Console.WriteLine("Producto actualizado con éxito.");
                Console.WriteLine("Pulse una tecla para continuar...");
                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("Producto no encontrado.");
        Console.WriteLine("Pulse una tecla para continuar...");
        Console.ReadKey();
    }

    public static void ConsultarProducto(List<Tuple<int, string, int, double>> productos)
    {
        if (productos.Count == 0)
        {
            Console.WriteLine("No hay productos en el inventario.");
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
            return;
        }

    }
}