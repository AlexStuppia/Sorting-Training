using System;

namespace Funzioni
{
    public class Sport
    {
      
        public string disciplina;
        public string livello;
        

        public Sport(string disciplina, string livello)
        {
            
            this.disciplina = disciplina;
            this.livello = livello;
        }

        public override string ToString()
        {
            return " Disciplina: " + this.disciplina + "\n" +
                   " categoria: " + this.livello + "\n";
        }
        
        //public static int OrdinaSportPerNome(Sport a1, Sport a2)
        //{
        //    if (a1.medaglie > a2.medaglie)
        //    {
        //        return -1;
        //    }
        //    else if (a1.medaglie < a2.medaglie)
        //    {
        //        return +1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

   

        public static int OrdinaSportPerDisciplinaAZ(Sport s1, Sport s2)
        {
            return s1.disciplina.CompareTo(s2.disciplina);
        }

        public static int OrdinaSportPerDisciplinaZA(Sport s1, Sport s2)
        {
            return -s1.disciplina.CompareTo(s2.disciplina);
        }

        public static int OrdinaSportPerLivelloAZ(Sport s1, Sport s2)
        {
            return s1.livello.CompareTo(s2.livello);
        }

        public static int OrdinaSportPerLivelloZA(Sport s1, Sport s2)
        {
            return -s1.livello.CompareTo(s2.livello);
        }






        //public static int OrdinaAtletiPerEtaEnomeSeEtaUguale(Sport a1, Sport a2)
        //{
        //    if (a1.eta > a2.eta)
        //    {
        //        return -1; // -1 o + 1 definiscono il tipo di ordinamento... decrescente o crescente
        //    }
        //    else if (a1.eta < a2.eta)
        //    {
        //        return +1;
        //    }
        //    else
        //    {
        //        return a1.nome.CompareTo(a2.nome);
        //    }

    }
   }
