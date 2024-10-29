
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;


//Intanciando el objeto
CajaRegistradora nuevaCompra = new CajaRegistradora(0);

//Informa para que sirve el programa
nuevaCompra.Contexto();

//Añade nuevos items al diccionario
nuevaCompra.NuevoCarro();

//Calcula el total del carro
nuevaCompra.TotalAi();

//Genera el ticket del carro
nuevaCompra.MostrarCarro();


//Construcción del programa
public class CajaRegistradora
{
    //Definición de parámetros
    private float total;
    public float impuesto;
    public float descuento;
    public float totalCarrito;
    string producto;
    string precio;
    string cantidad;
    char[] chars;
    char[] charsCant;
    string alerta = "No puedes dejar este campo vacío";
    Dictionary<string, Tuple<int, float>> carro = new Dictionary<string, Tuple<int, float>>();

    //Constructor
    public CajaRegistradora (float total)
    {
        this.total = total;
    }

    //Getters y Setters
 public float getTotal()
    {
        return total;
    }

public void setTotal(float total)
    {
        this.total=total;
    }

 //Métodos
    //Método para añadir items al carrito
    public void NuevoCarro()
    {

        // evita que se deje vacío el nombre del producto
        do
        {
            //Añade el artículo mediante su nombre
            do
            {
                Console.WriteLine("Ingrese nombre del producto");
                producto = Console.ReadLine();
                if (string.IsNullOrEmpty(producto))
                {
                    Console.WriteLine(alerta);
                }
                else
                {
                    break;
                }
            } while (string.IsNullOrEmpty(producto));

            // define la cantidad de productos que va a comprar
            do
            {
                Console.WriteLine("Ingrese la cantidad de productos : ");
                cantidad = Console.ReadLine();
                if (string.IsNullOrEmpty(cantidad))
                {
                    Console.WriteLine(alerta);
                }
                else if (!string.IsNullOrEmpty(cantidad))
                {
                    charsCant = cantidad.ToCharArray();
                    foreach (var d in charsCant)
                    {
                        if (d < 48 || d > 57)
                        {
                            Console.WriteLine(d + " es un caracter no valido");
                            goto Continua;
                        }
                        else
                        {
                            goto Fin;   
                        }
                    }
                }
            Continua:
                continue;
            Fin:
                break;
            } while (true);

            // añade el precio de los artículos
            do 
            {
                Console.WriteLine("Ingrese precio del producto: ");
                precio = Console.ReadLine();
                if (string.IsNullOrEmpty(precio))
                {
                    Console.WriteLine(alerta);
                }
                else if (!string.IsNullOrEmpty(precio))
                {
                    chars = precio.ToCharArray();
                    foreach (var c in chars)
                    {
                        if (c < 43 || c > 57)
                        {
                            Console.WriteLine(c + " es un caracter no valido");
                            goto Continua;
                        }
                        else
                        {
                            
                            carro.Add(producto,Tuple.Create(int.Parse(cantidad), Math.Abs(float.Parse(precio))));
                            goto Fin;
                        }
                    }
                }
            Continua:
                continue;
            Fin:
                break;
            } while (true);

            //Le da la opción al usuario de finalizar el programa
            Console.WriteLine("Presione + para añadir otro item o presione cualquier tecla para salir");
                string input = Console.ReadLine();
                if (input == "+")
                {
                    continue;
                }
                else
                {
                    break;
                }
        }while (true);
        Console.Clear();
    }


    //Métoddo para calcular el total del carro
    
    public void TotalAi()
    {
        float suma = 0;
        foreach (var value in carro)
        {
            suma += value.Value.Item2*value.Value.Item1;
        }
        setTotal(suma); 
    }
    //Método para calcular impuesto
    public float Impuestos()
    {
        impuesto = 0.15f;
        float calcImpuesto = total * impuesto;
        return calcImpuesto;
    }

    //Método para calcular descuento
    public float Descuento()
    {
        descuento = 0.05f;
        float calcDesc = total * descuento;
        return calcDesc;
    }
    //Método para generar el ticket del carrito
    public void MostrarCarro()
    {
        Console.WriteLine("SUPER BARATERO");
        Console.WriteLine("Cajero: Juan Pérez");
        Console.WriteLine("\ncantidad...producto.............precio unitario.........importe");    
        foreach (var item in carro)
        {
            Console.WriteLine( $"       {item.Value.Item1}...{item.Key}................${item.Value.Item2} MXN...........${item.Value.Item1*item.Value.Item2} MXN");
        }
        Console.WriteLine($"Subtotal ${total} MXN");
        Console.WriteLine($"Se le otorga un descuento de ${Descuento()} MXN");
        Console.WriteLine($"Su IVA es de ${Impuestos()} MXN");
        Console.WriteLine($"Total a pagar ${total-Descuento()+Impuestos()} MNX");
        Console.WriteLine("\n\nSi requiere factura puede solicitarla en \nwww.masfacturas.com/superbaratero/facturas \n\nNo te olvides de seguirnos en nuestras redes");
    }

    public void Contexto()
    {
        Console.WriteLine("Bienvenido a SUPERBARATERO \npara generar su tickect de compra ingrese los siguientes datos:" +
            "\nNombre del producto: (Ejemplo: Agua ciel 600 ml)" +
            "\nCantidad de artículos (Ejemplo: 12)" +
            "\nPrecio unitario del producto (Ejemplo: 25.5)" +
            "\nAl finalizar, presione enter para generar el ticket de compra");
    }
}