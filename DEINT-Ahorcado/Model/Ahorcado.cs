using Android.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ahorcado.Model
{
    internal class Ahorcado
    {
        public String palabraSecreta { get; set; }
        public int fase { get; set; }
        public IEnumerable<Char> letras { get; set; }
    }
}