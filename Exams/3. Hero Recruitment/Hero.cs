using System;
using System.Collections.Generic;

namespace _3._Hero_Recruitment
{
    public class Hero
    {
        public Hero(string name)
        {
            this.Name = name;
            this.SpellBook = new List<string>();
        }
        public string Name { get; set; }

        public List<string> SpellBook { get; set; }

        public override string ToString()
        {
            return $"== {this.Name}: " + String.Join(", ", this.SpellBook);
        }
    }
}
