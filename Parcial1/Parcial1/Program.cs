// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Parcial1.Entidades;
using Parcial1.Negocio;

Usuario user = new Usuario();
ClsUsuario clsUser = new ClsUsuario();


Console.WriteLine("Ingresa tu usuario");
user.user = Console.ReadLine();
Console.WriteLine("Ingresa tu Contraseña");
user.password = Console.ReadLine();

bool Resultado = clsUser.Autenticacion(user);
if (Resultado == true)
{
    Console.WriteLine("INICIO DE  SESIÓN CORRECTO PUEDES CONTINUAR CON EL PROCESO DE VENTA\n");
}
else
{
    Console.WriteLine("NOMBRE DE USUARIO INCORRECTO");
}

Venta venta = new Venta();
ClsVenta Clsventa = new ClsVenta();

Console.WriteLine("Ingrese Id del Producto");
venta.IdentificadorDeProducto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese Nombre Producto");
venta.NombreDelProducto = (Console.ReadLine());

Console.WriteLine("Ingrese descripcion del producto");
venta.DescripcionDelProducto = (Console.ReadLine());

Console.WriteLine("Ingrese el precio");
venta.PrecioDelProducto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad");
venta.CantidadDeProducto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Clsventa.Cobro(venta));