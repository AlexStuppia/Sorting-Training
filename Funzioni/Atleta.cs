using System;

namespace Funzioni
{
    public class Atleta
    {
        public string nome;
        public string cognome;
        public int eta;
        public Sport sport;
        public int medaglie;

        public Atleta(string nome, string cognome, int eta, Sport sport, int medaglie)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            this.sport = sport;
            this.medaglie = medaglie;
        }

        public override string ToString()
        {
            return this.nome + " " + this.cognome + "\n" +
                   "Età: " + this.eta + "\n" +
                     this.sport + "\n" +
                   "Medaglie: " + this.medaglie + "\n";
        }
        
        public static int OrdinaAtletiPerMedaglieDecrescente(Atleta a1, Atleta a2)
        {
            if (a1.medaglie > a2.medaglie)
            {
                return -1;
            }
            else if (a1.medaglie < a2.medaglie)
            {
                return +1;
            }
            else
            {
                return 0;
            }
        }

        public static int OrdinaAtletiPerDisciplinaSportAZ(Atleta a1, Atleta a2)
        {
            return a1.sport.disciplina.CompareTo(a2.sport.disciplina);
        }


        public static int OrdinaAtletiPerDisciplinaSportZA(Atleta a1, Atleta a2)
        {
            return -a1.sport.disciplina.CompareTo(a2.sport.disciplina);
        }

        public static int OrdinaAtletiPerLivelloSportAZ(Atleta a1, Atleta a2)
        {
            return a1.sport.livello.CompareTo(a2.sport.livello);
        }

        public static int OrdinaAtletiPerLivelloSportZA(Atleta a1, Atleta a2)
        {
            return -a1.sport.livello.CompareTo(a2.sport.livello);
        }



        public static int OrdinaAtletiPerEtaEnomeSeEtaUguale(Atleta a1, Atleta a2)
        {
            if (a1.eta > a2.eta)
            {
                return -1; // -1 o + 1 definiscono il tipo di ordinamento... decrescente o crescente
            }
            else if (a1.eta < a2.eta)
            {
                return +1;
            }
            else
            {
                return a1.nome.CompareTo(a2.nome);
            }

        }
    }
}