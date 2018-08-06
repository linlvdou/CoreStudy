using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo
{
    public class Mouse
    {
        private string name;

        public Mouse(string name)
        {
            this.name = name;
        }

        public void Run(object sender, CatShoutEventArgs args)
        {
            Console.WriteLine($"老猫{args.Name}来了，{name}快！");
        }
    }
}
