using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class SkillsLab : IInterns
    {
        private string name;
        private int id;
        public string NameId => $"SkillsLab - {name} : {id}";

        public SkillsLab(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
