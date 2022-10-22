using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomStack<string> stack = new CustomStack<string>();
            //stack.Push("Jedi-X");
            //stack.Pop();
            //stack.Push("Jedi");
            //stack.Push("SkillsLab");

            //while(stack.Count() > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            ICustomStack<Jedi>  jedis = new CustomStack<Jedi>();
            jedis.Push(new Jedi("John", 123));
            jedis.Push(new Jedi("Tom", 45));
            jedis.Push(new Jedi("Jack", 123));

            CustomStackExtendedOP.DisplayAllInternsNameAndId(jedis);

            Console.ReadLine();
        }
    }
}
