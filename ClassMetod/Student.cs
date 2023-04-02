using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClassMetod
{
    internal class Student
    {

        public string Name;
        public string Surname;
        public int Id;
        public Student(string Name,string Surname,int Id)
        {

            this.Name = Name;
            this.Surname = Surname;
            this.Id = Id;
        }
    }
        
}
