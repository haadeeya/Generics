using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class CustomStackExtendedOP
    {

        public static void DisplayAllInternsNameAndId(IReadOnlyCustomStack<IInterns> stack)
        {
            while (stack.Count() > 0)
            {
                var item = stack.Pop();
                Console.WriteLine(item.NameId);
            }
        }
    }
}
