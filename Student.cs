using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_ASM1
{
    class Student:Person,Std_role
    {
        public string stdId;
        public string stdBatch;

        //contructor
        public Student() { }
        public Student(string stdId,string stdBatch, string name, DateTime dob, string email, string address)
            :base(name,dob,email,address)
        {
            this.stdId = stdId;
            this.stdBatch = stdBatch;
        }

        //set, get
        public string StdID
        {
            get { return stdId; }  // Getter
            set { stdId = value; } // Setter
        }

        public string StdBatch
        {
            get { return stdBatch; }  // Getter
            set { stdBatch = value; } // Setter
        }

        //overloading
        public string knowledge;
        public string skill;
        public void evaluate(string same_value)
        {
            knowledge = same_value;
            skill = same_value;
        }

        public void evaluate(string Knowledge, string Skill)
        {
            knowledge = Knowledge;
            skill = Skill;
        }

        //thực thi abstract method
        public override void Activity()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Student "+name+ " do examination");
        }

        //thực thi interface method
        public void Do_exercise()
        {
            Console.WriteLine("Student " + name + " do exercise");
        }

        public void Feedback()
        {
            Console.WriteLine("Student " + name + " feedbak teacher");
        }

        public override void Input()
        {
            base.Input(); // Gọi phương thức của lớp person
                         // Thêm xử lý cho thuộc tính id và batch
            Console.Write("Input ID: ");
            stdId = Console.ReadLine();
            Console.Write("Input Batch: ");
            stdBatch = Console.ReadLine();
        }

        public  string displayStd()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("SHOW DETAIL:");
          //  base.display();
            return("StdID: "+StdID +"  "+"\nStdBatch: "+StdBatch+"  "+
                "\nName: "+name+"  "+"\nDate of birth: "+dob+"  "+"\nEmail: "+email+"  "+"\nAddress: "+address);
           
            /* 
            Console.WriteLine("StdBatch: {0}", stdBatch);
            Console.WriteLine("Knowledge: {0}", knowledge);
            Console.WriteLine("Skill: {0}", skill);
           */
        }

        public override void display()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("SHOW DETAIL:");
            base.display();
            Console.WriteLine("StdID: " + StdID + "  " + "StdBatch: " + StdBatch + "  " +
                "Knowdelge: " + knowledge + "  " + "Skill: " + skill);

            /* 
            Console.WriteLine("StdBatch: {0}", stdBatch);
            Console.WriteLine("Knowledge: {0}", knowledge);
            Console.WriteLine("Skill: {0}", skill);
           */
        }
    }
}
