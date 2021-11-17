using System;
using System.Collections.Generic;

//Vari tipi di ordinamento e comparazione tra oggetti e numeri
namespace Funzioni
{
    class Program
    {
        static void Main(string[] args)
        {
            Atleta atleta1 = new Atleta("Andrea", "Asioli", 43, "Bocce", 5);
            Atleta atleta2 = new Atleta("Fjoralba", "Myrtaj", 27, "Nuoto", 10);
            Atleta atleta3 = new Atleta("Nicolò", "Giuggiola", 27, "Scherma", 12);
            Atleta atleta4 = new Atleta("Viviana", "Bobbio", 55, "Bocce", 5);
            Atleta atleta5 = new Atleta("Mirko", "Nardangeli", 35, "Skateboard", 20);
            Atleta atleta6 = new Atleta("Samuel", "Mameli", 34, "Wrestling", 18);
            Atleta atleta7 = new Atleta("Marco", "Muni", 27, "Calcio", 12);
            Atleta atleta8 = new Atleta("Ezio", "Ferrante", 51, "Savate", 15);
            Atleta atleta9 = new Atleta("Alex", "Stuppia", 21, "Kick-Boxing", 100000000);

            Atleta[] atleti = { atleta1, atleta2, atleta3, atleta4, atleta5, atleta6, atleta7, atleta8, atleta9 };
            List<Atleta> listDiAtleta = new List<Atleta>() { atleta1, atleta2, atleta3, atleta4, atleta5, atleta6, atleta7, atleta8, atleta9 };
            Array.Sort(atleti, Atleta.OrdinaAtletiPerEtaEnomeSeEtaUguale); // array.sort sceglie il miglior algoritmo per effettuare la comparazione
            Console.WriteLine("Array.sort di array normale");
            for (int i = 0; i < atleti.Length; i++)
            {
                Console.WriteLine(atleti[i].ToString() + "\n");
            }

            Console.WriteLine("List.Sort di una lista");
            listDiAtleta.Sort(Atleta.OrdinaAtletiPerEtaEnomeSeEtaUguale);

            for (int i = 0; i < listDiAtleta.Count; i++)
            {
                Console.WriteLine(listDiAtleta[i].ToString() + "\n");
            }

            //BUBBLE SORT!
            Console.WriteLine("Bubble sort di numeri");
            BubbleSort(new int[]{1,2,3,6,8,11,14,22,100,22,45 });

            Console.WriteLine("Bubble sort di oggetti Atleta per numero medaglie decrescente");
            BubbleSortAtleti(atleti, Atleta.OrdinaAtletiPerMedaglieDecrescente);

        }//end main

      

        static void BubbleSort(int[] numeri)
        {
            //Bubble sort
            
            int temp = 0; //dichiarare temp fuori dal ciclo o all'interno del primo for è indifferente
            for (int i = 0; i < numeri.Length; i++)
            {
                for (int j = i + 1; j < numeri.Length; j++)
                {
                    if (numeri[i] > numeri[j])
                    {
                        temp = numeri[i];
                        numeri[i] = numeri[j];
                        numeri[j] = temp;
                    }
                }
                Console.WriteLine(numeri[i]);
            }
        }

        static void BubbleSortAtleti(Atleta[] atleti, Func<Atleta, Atleta, int> compareAtleta) // questo è un placeholder per la funzione che gli passiamo poi a parametro, e dunque gli anticipiamo cosa gli serve
            //2 oggetti Atleta (da comparare all'interno del if) e l'ouput che sarà un int, 0 o 1 o -1 (che sono i tipi di ritorno del compareTo in sostanza, che definiscono il tipo di ordinamento)
            //crescente, decrescente o non cambiare niente
        {
            Atleta temp = null; //dichiarare temp fuori dal ciclo o all'interno del primo for è indifferente
            for (int i = 0; i < atleti.Length; i++)
            {
                for (int j = i + 1; j < atleti.Length; j++)
                {
                    if (compareAtleta(atleti[i], atleti[j]) > 0) //questa comparazione verrà rimpiazzata dalla func che arriverà a parametro, attualmente nel main gli passiamo OrdinaAtletiPerMedaglieDecrescente
                    {
                        temp = atleti[i];
                        atleti[i] = atleti[j];
                        atleti[j] = temp;
                    }
                }
                Console.WriteLine(atleti[i]);
            }
        }



    }
}
