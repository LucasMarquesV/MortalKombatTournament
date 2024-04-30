using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class LutadorModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public int ArtesMarciais { get; set; }

        public int TotalDeLutas { get; set; }

        public int Derrotas { get; set; }

        public int Vitorias { get; set; }
    }
}
