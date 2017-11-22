using System;
using System.Collections.Generic;

namespace ExemploLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> sacola = new List<Produto>();

            HigienePessoal sabonete = new HigienePessoal();
            sabonete.id = 10;
            sabonete.nome="Dove";
            sabonete.numeroMS = "84548";
            sabonete.marca = "P&G";

            Bebidas cerveja = new Bebidas();
            cerveja.id = 10;
            cerveja.nome = "Skol";
            cerveja.teoralcoolico = 6.5;
            cerveja.tipo = "Alcolica";

            sacola.Add(sabonete);
            sacola.Add(cerveja);

            foreach (var item in sacola)
            {
                string classe = item.GetType().ToString();

                switch (classe)
                {
                    case "ExemploLista.HigienePessoal":
                    {
                        HigienePessoal higiene = (HigienePessoal)item;
                        Console.WriteLine("Higiene Pessoal: " + higiene.nome + " - "
                                                              + higiene.numeroMS + " - "
                                                              + higiene.marca);
                        break;
                    }
                    case "ExemploLista.Bebidas":
                    {
                        Bebidas bebida = (Bebidas)item;
                        Console.WriteLine("Bebidas: " + bebida.nome + " - "
                                                      + bebida.teoralcoolico + " - "
                                                      + bebida.tipo);
                        break;
                    }

                }
            }

            
        }
    }
}
