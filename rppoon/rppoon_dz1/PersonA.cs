using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz1
{
    class PersonA : Person
    {
        public string PersonNickname { get; set; }
        public PersonA(string personNickname,string name, int id, int age) : base(name, id, age)
        {
            PersonNickname = personNickname;
        }

        public override void Greet()
        {
            base.Greet();
            Console.WriteLine(" I am a person");
        }
    }
}
