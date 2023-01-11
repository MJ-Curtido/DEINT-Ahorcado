using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ahorcado.Model
{
    public class Ahorcado
    {
        Random rnd = new Random();
        public List<String> palabras { get; set; } = new List<String>() { "dam", "estudiar", "programar", "ordenador", "teclado", "raton", "alfombrilla", "monitor" };
        public int fase { get; set; }
        public IEnumerable<Char> letras { get; set; } = new List<Char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        public Ahorcado()
        {

        }

        public String getPalabraSecreta()
        {
            return palabras.OrderBy(a => rnd.Next()).ToList().First();
        }
    }
}