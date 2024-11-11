using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videam.Models
{
    public class Scene
    {
        public string Name { get; set; }    

        public Scene(string name) 
        { 
            Name = name;
        }
    }
}
