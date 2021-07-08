using System;

namespace Delegates
{
    public delegate void MyDelegete();

    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMassage();
            customerManager.ShowAlert();

            MyDelegete myDelegete = customerManager.SendMassage;
            myDelegete += customerManager.ShowAlert;
            myDelegete();





        }
    }
    class CustomerManager
    {

        public void SendMassage()
        {
            Console.WriteLine("hello");


        }


        public void ShowAlert()
        {
            Console.WriteLine("Be caneful!");


        }


    }


}
