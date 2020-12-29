using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class User
    {
        // Fields (attributes)
        public String Name;
        
        public User(String name)
        {
            Name = name;
        }    
        
        // Methods
        public void SayHello()
        {
            Console.WriteLine($"Hei, minun nimeni on {Name}.");
        }
    }
}
