using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinQ_Ejemplos_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arregloEnteros = { 1, 2, 4, 5, 8, 22, 35, 67, 29 };
            IEnumerable<int> lst = from d in arregloEnteros
                                   orderby d
                                   select d;
            IEnumerable<int> lst1 = from d in arregloEnteros
                                    where d == 2 || d == 22
                                    select d;


            Complejo[] lst3 = {
                new Complejo(3,"Urzaiz"),
                new Complejo (8,"Muniain"),
                new Complejo (4,"Fran Vazquez"),
                new Complejo (2,"Dani Garcia")

            };

            var jugador = (from d in lst3
                            where d.Cadena =="Muniain"
                            select d).FirstOrDefault();

            Console.WriteLine(jugador.imprime());

            var listarPorNumero = (from d in lst3
                                   orderby d.Numero
                                   select d);

            foreach (var a in listarPorNumero)
            {
                Console.WriteLine(a.imprime());
            }

            foreach (var a in lst)
            {

                Console.WriteLine("Estos son los numeros del primer ejemplo " + a);
            }

            foreach (var a in lst1)
            {

                Console.WriteLine("Estos son los numeros del segundo ejemplo " + a);
            }


        }

            public class Complejo

          {
                  public int Numero { get; set; }
                 public string Cadena { get; set; }

             public Complejo(int Numero,string Cadena)
            {
                this.Numero = Numero;
                this.Cadena = Cadena;
            }

            public String imprime() 
            {
                return Numero + " " + Cadena;
            }
          }
        }
    }

