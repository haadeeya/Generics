using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Jedi : IInterns
    {
        private string name;
        private int id;
        public string NameId => $"Jedi - {name} : {id}";

        public Jedi(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }

}
