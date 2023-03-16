using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VerificaDebito
{
    internal class Alunno
    {
        public Alunno(string nome,string cognome,int età,string cittàDiResidenza)
        {
            
        }
        
        public Alunno()
        {

        }

        public string nome { get; set; }
        public string cognome { get; set; }
        public int età { get; set; }
        public string cittàDiResidenza { get; set; }

        public string[] a = new string[5];

        

        

        public string[] toString(string[] listaDiDati,string nome, string cognome, string età, string cittàDiResidenza)
        {
            

            listaDiDati[0] = nome;
            listaDiDati[1] = cognome;
            listaDiDati[2] = età;
            listaDiDati[3] = cittàDiResidenza;
            a = listaDiDati;
            return listaDiDati;
        }

        public string classi(string biennio,string triennio,int età)
        {
            biennio = "biennio";
            triennio = "triennio";
            if(età > 16)
            {
               
                return triennio;
            }
            else
            {

                return biennio;
            }
            
        }

    }
}
