using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ahorcado.Model
{
    public class Ahorcado
    {
        public String palabraSecreta { get; set; }
        public int fase { get; set; }
        public IEnumerable<Char> letras { get; set; } = new List<Char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        public Ahorcado()
        {

        }
    }
}