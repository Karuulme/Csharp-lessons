using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Class1
    {
    }

    class BaseClass
    {

       private string _message;
        public BaseClass(string message)
        {


            _message = message;
        }

        public void Messaga()
        {


            Console.WriteLine("{0} Message",_message);
        }
    }
    class PersonManager : BaseClass
    {

        public PersonManager(string mesaage) : base(mesaage)
        {


        }
        public void Add()
        {

            Console.WriteLine("Added!");
            Messaga();
        }
    }
}
