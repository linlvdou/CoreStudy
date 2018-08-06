using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo
{
    public class Cat
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public delegate void CatShoutEventHandler(object sender, CatShoutEventArgs args);
        public event CatShoutEventHandler CatShout;

        public void Shout()
        {
            Console.WriteLine($"喵~，我是{name}。");
            if (CatShout != null)
            {
                CatShoutEventArgs args = new CatShoutEventArgs();
                args.Name = this.name;
                CatShout(this, args);
            }
        }
    }
}
