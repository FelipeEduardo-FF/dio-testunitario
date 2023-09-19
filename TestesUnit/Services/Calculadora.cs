using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProject.Services
{
    public class Calculadora
    {

        List<string> listhistorico;
        string Data;

        public Calculadora(string data)
        {
            listhistorico = new List<string>();
            Data= data;
        }
        public int somar(int val1,int val2)
        {
            var result = val1 + val2;
            listhistorico.Insert(0, "res:" + result + "data "+ Data);
            return result;
        }

        public int subtrair(int val1, int val2)
        {
            var result = val1 - val2;
            listhistorico.Insert(0, "res:" + result + "data " + Data);
            return result;
        }

        public int multiplicar(int val1, int val2)
        {
            var result = val1 * val2;
            listhistorico.Insert(0, "res:" + result + "data " + Data);
            return result;
        }

        public int dividir(int val1, int val2)
        {
            var result = val1 / val2;
            listhistorico.Insert(0, "res:" + result + "data " + Data);
            return result;
        }

        public List<string> historico()
        {

            listhistorico.RemoveRange(3,listhistorico.Count()-3);

            return new List<string>(listhistorico);
        }
    }
}
