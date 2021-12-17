using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_ASM1
{
    abstract class Person
    {
        protected string Name;
        protected DateTime Dob;
        protected string Email;
        protected string Address;

        public Person()
        {

        }

        public Person(string name, DateTime dob, string email, string address)
        {
            Name = name;
            Dob = dob;
            Email = email;
            Address = address;
        }


        // method

        public string name
        {
            get { return Name; }  // Getter
            set { Name = value; } // Setter
        }

        public DateTime dob
        {
            get { return Dob; }  // Getter
            set { Dob = value; } // Setter
        }

        public string email
        {
            get { return Email; }  // Getter
            set { Email = value; } // Setter
        }

        public string address
        {
            get { return Address; }  // Getter
            set { Address = value; } // Setter
        }
        // public string name { get => name; set => name = value; }
        /* public string dob { get =>dob; set => dob = value; }
         public string email { get => email; set => email= value; }
         public string address { get => address; set => address = value; }
        */

        //ham nhap du lieu
        public virtual void Input()
        {
            Console.Write("Input name: ");
            name = Console.ReadLine();
            Console.Write("Input dob: ");
            dob = DateTime.Parse(Console.ReadLine());
            Console.Write("Input email: ");
            email = Console.ReadLine();
            Console.Write("Input address: ");
            address = Console.ReadLine();
        }

        public virtual void display()
        {
            Console.WriteLine("Name: " + Name +"     "
                + "Dob: " + Dob + "     " + "Email: " 
                + Email + "     " + "Address: " + Address);
         /*   Console.WriteLine("Dob: " + Dob);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Address: " + Address);
         */
        }

        //khởi tạo abstract method
        public abstract void Activity();
      

    }
}
