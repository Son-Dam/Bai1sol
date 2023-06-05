using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class CanBo
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public CanBo(string Name, Gender Gender, int Age)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Age = Age;
        }
        
    }
}
