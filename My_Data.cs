using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_4_Test
{
    internal class My_Data
    {
        public string Pivo;
        public int Pivnoi_Procent;
        public string Pivnoi_Chivot;
        public string Ckufism;
        public My_Data(string pivo, int pivnoi_procent, string pivnoi_chivnot, string ckufism) 
        {
            Pivo = pivo;
            Pivnoi_Procent = pivnoi_procent;
            Pivnoi_Chivot = pivnoi_chivnot;
            Ckufism = ckufism;
        }    
    }
    public enum Answers
    {
        FirstAnswerCorrect,
        SecondAnswerCorrect,
        ThirdAnswerCorrect
    }
}
