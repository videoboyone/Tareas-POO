using System;
using System.IO;
using System.Collections.Generic;

namespace Proyecto
{

    class Producto
    {
        public string codigo;
        public string descripcion;
       public decimal precio;
        public int departamento;
        public int likes;

        public Producto(string codigo, string descripcion, decimal precio, int departamento, int likes)
        {   
            this.codigo=codigo;
            this.descripcion=descripcion;
            this.precio=precio;
            this.departamento=departamento;
            this.likes=likes;
        }
    }

    class ProductDB
    {
        //Metodo para guardar archivo de texto
        public static void SaveProducto(string path, List<Producto>productos)
        {
            //Se crea objeto tipo StreamWriter, para crear el archivo de productos
            try
            {

            
            StreamWriter txtOut=new StreamWriter(new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write));
             foreach (Producto p in productos)
             {
                 txtOut.Write(p.codigo + "|");
                 txtOut.Write(p.departamento + "|" );
                 txtOut.Write(p.descripcion + "|" );
                 txtOut.Write(p.precio + "|");
                 txtOut.WriteLine(p.likes);
                 
             }
             txtOut.Close();
            }
                catch(FileNotFoundException)
                {
                    Console.WriteLine(path + "no se encontró","Archivo no encontrado");
                }
                catch(DirectoryNotFoundException)
                {
                    Console.WriteLine("Directorio no encontrado, favor de especificar","Directorio no encontrado");
                }
                catch(IOException ex)
                {
                    Console.WriteLine(ex.Message,"IOException");
                }
             
             
        }


         //Metodo para leer archivo de texto
         public static List<Producto> ReadProducto(string path)
                {
                    List<Producto>productos=new List<Producto>();
                    try
                    {                                        
                   StreamReader txtIn=new StreamReader(new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read));
                   while(txtIn.Peek()!=-1)
                   {
                       string row=txtIn.ReadLine();
                       string[]columns=row.Split('|');
                       Console.WriteLine(columns[1]);
                       Producto p=new Producto(columns[0],columns[1],decimal.Parse(columns[2]),int.Parse(columns[3]),int.Parse(columns[4]));
                       productos.Add(p);
                       
                   }
                   txtIn.Close();                   
                    }
                    catch(FileNotFoundException)
                    {
                        Console.WriteLine(path + "no se encontró","Archivo no encontrado");
                    }
                    catch(DirectoryNotFoundException)
                    {
                         Console.WriteLine("Directorio no encontrado, favor de especificar","Directorio no encontrado");
                    }
                    catch(IOException ex)
                    {
                        Console.WriteLine(ex.Message,"IOException");
                    }
                    return productos;
                }


                //Metodo para escribir archivo binario
                public static void SaveBinary(string path,List<Producto>productos)
                {
                    try
                    {

                    
                   BinaryWriter binaryOut=new BinaryWriter(new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write));

                   foreach(Producto producto in productos)
                   {
                       binaryOut.Write(producto.codigo);
                       binaryOut.Write(producto.departamento);
                       binaryOut.Write(producto.descripcion);
                       binaryOut.Write(producto.precio);
                       binaryOut.Write(producto.precio);

                   }
                   binaryOut.Close();
                    }
                    catch(FileNotFoundException)
                    {
                       Console.WriteLine(path + "no se encontró","Archivo no encontrado"); 
                    }
                    catch(DirectoryNotFoundException)
                    {
                        Console.WriteLine("Directorio no encontrado, favor de especificar","Directorio no encontrado");
                    }
                    catch(IOException ex)
                    {
                        Console.WriteLine(ex.Message,"IOException");
                    }
                }


                //Metodo para leer en binario
                public static List<Producto>ReadBinary(string path)
                {
                    List<Producto>productos=new List<Producto>();
                    try
                    {                  
                    BinaryReader binaryIn=new BinaryReader(new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read));    
                    while(binaryIn.PeekChar()!=-1)
                    {
                        Producto p=new Producto(binaryIn.ReadString(),binaryIn.ReadString(),binaryIn.ReadDecimal(),binaryIn.ReadInt32(),binaryIn.ReadInt32());
                        productos.Add(p);
                    }
                    binaryIn.Close();
                    return productos;
                    }
                    catch(FileNotFoundException)
                    {
                        Console.WriteLine(path + "no se encontró","Archivo no encontrado");
                    }
                    catch(DirectoryNotFoundException)
                    {
                        Console.WriteLine("Directorio no encontrado, favor de especificar","Directorio no encontrado");
                    }
                    catch(IOException ex)
                    {
                        Console.WriteLine(ex.Message,"IOException");
                    }
                    return productos;

                }


                //Metodo GetDepartamento que imprime objetos pertenecientes a un depto. en especifico
                public static void GetDepartamento(int departamento, string path)
                {
                    List<Producto> productos=ReadProducto(path);
                    foreach(Producto producto in productos)
                    {
                        if (producto.departamento==departamento)
                        {
                            Console.Write(producto);
                        }
                    }


                }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea lista de productos 
            List<Producto>productos=new List<Producto>();
            productos.Add(new Producto("001","Teclado",200,100,31));
            productos.Add(new Producto("002","Mouse",90,100,22));
            productos.Add(new Producto("003","Lavadora",5000,900,14));
            productos.Add(new Producto("004","Café",50,700,25));
            productos.Add(new Producto("005","Hojas",140,200,42));

            string path="productos.txt";
            

            ProductDB.SaveProducto("Productos.txt",productos);
            ProductDB.SaveBinary("productos.bin",productos);
            ProductDB.GetDepartamento(100,path);
        }
    }
}