using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CustomStack<IInterns> : ICustomStack<IInterns>
    {
        IInterns[] elements = new IInterns[10];
         int index { get; set; } = -1;

        public CustomStack()
        {

        }

        public void Push(IInterns value)
        {
            index++;
            elements[index] = value;
        }

        public IInterns Pop()
        {

            IInterns result = elements[index];
            index--;
            return result;

        }

        public int Count()
        {
            return index;
        }



    }

}
