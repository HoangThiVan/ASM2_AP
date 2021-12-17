using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_ASM1
{
    class Lecturer:Person,Lec_role

    {
        public string lecId;
        public string lecBatch;

        public Lecturer(string stdId, string stdBatch, string name, DateTime dob, string email, string address)
            : base(name, dob, email, address)
        {
            this.lecId = stdId;
            this.lecBatch = stdBatch;
        }

        //set,get
        public string LecID
        {
            get { return lecId; }  // Getter
            set { lecId = value; } // Setter
        }

        public string LecBatch
        {
            get { return lecBatch; }  // Getter
            set { lecBatch = value; } // Setter
        }

        //thực thi abstract method
        public override void Activity()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Lecturer " + name + " evaluate student");
        }

        public override void Input()
        {
            base.Input(); // Gọi phương thức của lớp person
                          // Thêm xử lý cho thuộc tính id và batch
            Console.Write("Input ID: ");
            lecId = Console.ReadLine();
            Console.Write("Input Batch: ");
            lecBatch = Console.ReadLine();
        }

        public string displayLec()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("SHOW DETAIL:");
            //base.display();
            return ("LecID: " + LecID + "  " + "\nLecBatch: " + LecBatch + "  " +
                "\nName: " + name + "  " + "\nDate of birth: " + dob + "  " + "\nEmail: " + email + "  " + "\nAddress: " + address);

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
            Console.WriteLine("LecID: " + lecId + "  " + "LecBatch: " + lecBatch);

            /* 
            Console.WriteLine("StdBatch: {0}", stdBatch);
            Console.WriteLine("Knowledge: {0}", knowledge);
            Console.WriteLine("Skill: {0}", skill);
           */
        }

        public void grade()
        {
            Console.WriteLine("Lecturer " + name + " grade assignment");
        }

        public void Check_attendance()
        {
            Console.WriteLine("Lecturer " + name + " check attendance when the lesson begin");
        }

        public void Judge_lesson()
        {
            Console.WriteLine("Lecturer " + name + " judge the lesson when the lesson finish ");
        }
    }
}
