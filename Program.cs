using System;

class Principal
{
    static void Main()
    {
        //Punto 1

        //    Cuenta cuenta = new Cuenta(0);
        //    int opc = 0;
        //    do
        //    {
        //        Console.WriteLine("\n1. Consignar a tu cuenta" +
        //            "\n2. Retirar de tu cuenta" +
        //            "\n3. Verificar saldo" +
        //            "\n0. Salir");
        //        Console.WriteLine("\nElige: ");
        //        opc = Convert.ToInt32(Console.ReadLine());
        //        switch (opc)
        //        {
        //            case 0:
        //                Console.WriteLine("\nHasta luego...");
        //                break;
        //            case 1:
        //                cuenta.credit();
        //                break;
        //            case 2:
        //                cuenta.cargar();
        //                break;
        //            case 3:
        //                cuenta.obtenerSaldo();
        //                break;
        //            default:
        //                Console.WriteLine("\nLo sentimos ingresa una opcion valida");
        //                break;
        //        }

        //    } while (opc != 0);



        //Punto 2

        //    Factura factura = new Factura("", "", 0,0);
        //    int opc = 0;
        //    do
        //    {
        //        Console.WriteLine("\n1. Ingresar producto" +
        //            "\n2. Facturar" +
        //            "\n0. Salir");
        //        Console.WriteLine("\nElige: ");
        //        opc = Convert.ToInt32(Console.ReadLine());
        //        switch (opc)
        //        {
        //            case 0:
        //                Console.WriteLine("\nHasta luego...");
        //                break;
        //            case 1:
        //                Console.WriteLine("\nIngresa el número de pieza: ");
        //                string num = Console.ReadLine();
        //                factura.establecerNumPieza(num);
        //                Console.WriteLine("\nIngresa la descripcion de la pieza: ");
        //                string descripcion = Console.ReadLine();
        //                factura.establecerDescripcionPieza(descripcion);
        //                Console.WriteLine("\nIngresa la cantidad: ");
        //                int cantidad = Convert.ToInt32(Console.ReadLine());
        //                factura.establecerCantidadPieza(cantidad);
        //                if (cantidad < 0)
        //                {
        //                    factura.establecerCantidadPieza(0);
        //                }
        //                else
        //                {
        //                    factura.establecerCantidadPieza(cantidad);
        //                }
        //                Console.WriteLine("\nIngresa el precio: ");
        //                int precio = Convert.ToInt32(Console.ReadLine());
        //                if (precio < 0)
        //                {
        //                    factura.establecerPrecioPieza(0);
        //                }
        //                else
        //                {
        //                    factura.establecerPrecioPieza(precio);
        //                }
        //                break;
        //            case 2:
        //                Console.WriteLine("\nNum Pieza: "+factura.obtenerNumPieza());
        //                Console.WriteLine("\nDescripción Pieza: " + factura.obtenerDescripcionPieza());
        //                Console.WriteLine("\nCantidad Pieza: " + factura.obtenerCantidadPieza());
        //                Console.WriteLine("\nPrecio Pieza: " + factura.obtenerPrecioPieza());
        //                Console.WriteLine("\nValor total a pagar es " + factura.obtenerMontoFactura());
        //                break;
        //            default:
        //                Console.WriteLine("\nLo sentimos ingresa una opción valida");
        //                break;
        //        }
        //    } while (opc != 0);

    }
}

//Punto 1

//class Cuenta
//{
//    //Atributos
//    public int saldoCuenta;


//    //Metodo Constructor
//    public Cuenta(int saldoCuenta)
//    {
//        if (saldoCuenta == 0)
//        {
//            this.saldoCuenta = saldoCuenta;
//        }
//        else
//        {
//            Console.WriteLine("\nLo sentimos la cuenta debe estar en ceros.");
//        }
//    }


//    //Metodos
//    public void credit()
//    {
//        Console.WriteLine("\n¿Cuanto deseas consignar?");
//        int consignacion = Convert.ToInt32(Console.ReadLine());
//        if (consignacion < 0)
//        {
//            Console.WriteLine("\nLo sentimos, ingresa valores positivos.");
//        }
//        else
//        {
//            saldoCuenta += consignacion;
//            Console.WriteLine("\nTu nuevo saldo es de " + saldoCuenta);
//        }
//    }

//    public void cargar()
//    {
//        Console.WriteLine("\n¿Cuanto deseas retirar?");
//        int retiro = Convert.ToInt32(Console.ReadLine());
//        if (retiro > saldoCuenta)
//        {
//            Console.WriteLine("\nLo sentimos saldos insuficientes.");
//        }
//        else
//        {
//            saldoCuenta -= retiro;
//            Console.WriteLine("\nTu nuevo saldo es de " + saldoCuenta);
//        }
//    }

//    public void obtenerSaldo()
//    {
//        Console.WriteLine("Tu saldo actual es de: " + saldoCuenta);
//    }

//}

//Punto 2

//class Factura
//{
//    //Atributos
//    public string numPieza;
//    public string descripcionPieza;
//    public int cantidadPieza;
//    public int precioPieza;


//    //Metodo Constructor
//    public Factura(string numPieza, string descripcion, int cantidad, int precio)
//    {
//        this.numPieza = numPieza;
//        this.descripcionPieza = descripcion;
//        if (cantidad < 0)
//        {
//            this.cantidadPieza = 0;
//        }
//        else
//        {
//            this.cantidadPieza = cantidad;
//        }
//        if (precio < 0)
//        {
//            this.precioPieza = 0;
//        }
//        else
//        {
//            this.precioPieza = precio;
//        }
//    }


//    //Metodos
//    public void establecerNumPieza(string numPieza)
//    {
//        this.numPieza = numPieza;
//    }

//    public string obtenerNumPieza()
//    {
//        return this.numPieza;
//    }

//    public void establecerDescripcionPieza(string descripcion)
//    {
//        this.descripcionPieza = descripcion;
//    }

//    public string obtenerDescripcionPieza()
//    {
//        return this.descripcionPieza;
//    }

//    public void establecerCantidadPieza(int cantidad)
//    {
//        this.cantidadPieza = cantidad;
//    }

//    public int obtenerCantidadPieza()
//    {
//        return this.cantidadPieza;
//    }

//    public void establecerPrecioPieza(int precio)
//    {
//        this.precioPieza = precio;
//    }

//    public int obtenerPrecioPieza()
//    {
//        return this.precioPieza;
//    }

//    public int obtenerMontoFactura()
//    {
//        int totalPagar = this.cantidadPieza * this.precioPieza;
//        return totalPagar;
//    }
//}