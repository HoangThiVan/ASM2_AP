using System;
using System.Collections.Generic;

namespace Demo_ASM1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Student st1 = new Student();
           st1.Input();
           st1.evaluate("Good");
           st1.display();
           st1.Activity();
           st1.Do_exercise();
           Console.WriteLine("--------------------------");
            

            
           Student st2 = new Student();
            st2.Input();
            st2.evaluate("good", "excilent");
            st2.display();
            
            st2.Activity();
            //st2.Do_exercise();
            

        */

            //chuong trinh chinh***********************************************
        //**************************************************************************
        
            // create 2 lists of Student and lecturer
            List<Student> List_std = new List<Student>();
            List<Lecturer> List_lec = new List<Lecturer>();

            while (true)
            {
                try
                {
                    //Menu chinh
                    Console.WriteLine("*** STUDENT MANAGEMENT SYSTEM ***\n");
                    Console.WriteLine("--------------***************------------");
                    Console.WriteLine("1.   Students management systems");
                    Console.WriteLine("2.   Lecturers management systems");
                    Console.WriteLine("3.   Exit Program");
                    Console.WriteLine("-------------****************-------------");
                    Console.Write("Please choose an option: ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (choice)
                    {
                        //Case1: qlsv
                        case 1:
                            // Sub menu:student
                            while (true)
                            {
                                try
                                {

                               
                                    Console.WriteLine();
                                    Console.WriteLine("\t\n------**** STUDENT MANAGEMENT SYSTEM ****-----");
                                    Console.WriteLine("\tPlease choose a function:");
                                    Console.WriteLine("-----------------**************************-----------------");
                                    Console.WriteLine(" 1.Add new student");
                                    Console.WriteLine(" 2.  View all students");
                                    Console.WriteLine(" 3.  Update student");
                                    Console.WriteLine(" 4.  Delete students");
                                    Console.WriteLine(" 5.  Search students");
                                    Console.WriteLine(" 6.  Back to main menu");
                                    Console.WriteLine("--------------------**************************-------------------------");
                                       

                                    Console.Write("Please choose a function: ");
                                    int chon = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    //add student
                                    if (chon == 1)
                                    {
                                        Console.WriteLine("Let add a new student");
                                        Console.WriteLine("=====================");
                                        Console.Write(" Input Student's id: ");
                                        //check the number of characters entered 
                                        const int idMax = 3;
                                        string id = Console.ReadLine();
                                        if (id.Length > idMax)
                                        {
                                            //cat id xuong 3 ky tu
                                            id = id.Substring(0, idMax);
                                            Console.WriteLine("*Id has been cut to 3 characters!\n");
                                        }
                                        Console.Write("Input Student's Batch: ");
                                        string batch = Console.ReadLine();
                                        Console.Write("Input Student's name: ");
                                        string name = Console.ReadLine();
                                        Console.Write("Date of birth: ");
                                        DateTime dob = DateTime.Parse(Console.ReadLine());
                                        Console.Write("Mail: ");
                                        string mail = Console.ReadLine();
                                        Console.Write("Address: ");
                                        string address = Console.ReadLine();

                                        List_std.Add(new Student(id, batch, name, dob, mail, address));
                                        Console.WriteLine("\nAdd a Student Successfully!");
                                    }

                                    //view all student
                                    else if (chon == 2)
                                    {
                                        Console.WriteLine("----SHOW LIST OF STUDENT---\n");
                                        Console.WriteLine("**********************************");
                                        foreach (Student st in List_std)
                                        {
                                            Console.WriteLine(st.displayStd());
                                            Console.WriteLine("DONE!******************************");
                                        }
                                    }
                                    else if (chon == 3)
                                    {
                                        Console.WriteLine("Update Student profile");
                                        Console.WriteLine("****************************\n");
                                        Console.Write("Enter student's Id that you want to update: ");
                                        string UpdateById = Console.ReadLine();
                                        Student updateStudent = List_std.Find(x => x.StdID.Equals(UpdateById));
                                        if (updateStudent == null)
                                        {
                                            Console.WriteLine("Can not find the Student!");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Update a student");
                                            Console.WriteLine("****************************\n");
                                            Console.Write("Input new Batch: ");
                                            updateStudent.StdBatch = Console.ReadLine();
                                            Console.Write("Input new name: ");
                                            updateStudent.name = Console.ReadLine();
                                            Console.Write("Input new dob: ");
                                            updateStudent.dob = DateTime.Parse(Console.ReadLine());
                                            Console.Write("Input new Address: ");
                                            updateStudent.address = Console.ReadLine();
                                            Console.Write("Input new Mail: ");
                                            updateStudent.email = Console.ReadLine();
                                            

                                            Console.WriteLine("\nUpdated a Student Successfully!");
                                        }
                                    }
                                    //delete student
                                    else if (chon == 4)
                                    {
                                        Console.WriteLine("Delete a student from list");
                                        Console.WriteLine("*****************************\n");
                                        Console.Write("Input student's Id that you want to delete: ");
                                        string DeleteById = Console.ReadLine();
                                        Student deleteStudent = List_std.Find(x => x.StdID.Equals(DeleteById));
                                        if (deleteStudent == null)
                                            Console.WriteLine("Can not find the student!");
                                        else
                                        {
                                            List_std.Remove(deleteStudent);
                                            Console.WriteLine("Removed a student Successfully!");
                                        }
                                    }
                                    //Search student
                                    else if (chon == 5)
                                    {
                                        Console.WriteLine("Searching a students");
                                        Console.WriteLine("******************************\n");
                                        Console.Write("Enter Student's id: ");
                                        string SearchByNameOrId = Console.ReadLine();
                                        Student SearchStudent = List_std.Find(x => x.name.Contains(SearchByNameOrId) || x.StdID.Equals(SearchByNameOrId));

                                        

                                        Console.WriteLine(SearchStudent.displayStd());
                                    }
                                    else if (chon == 6)
                                    { break; }


                                }
                                catch
                                {
                                    Console.WriteLine("Notification: Please check the input data!");
                                }


                                   
                               
                            }
                        break;
                        //case 2: Manage Lecturer
                      case 2:
                            while (true)
                            {
                                Console.WriteLine("\t*** LECTURER MANAGEMENT SYSTEM ***");
                                Console.WriteLine("\tPlease choose a functions");
                                Console.WriteLine("======================================================" +
                                "\n\t 1.  Add new lecturer" +
                                "\n\t 2.  View all lecturers" +
                                "\n\t 3.  Update lecturer" +
                                "\n\t 4.  Delete Lecturer" +
                                "\n\t 5.  Search lecturers" +
                                "\n\t 6.  Back to main menu" +
                                "\n======================================================"
                                );

                                // Sub Menu - Lecturer
                                try
                                {
                                    Console.Write("Please choose an option: ");
                                    int chonn = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    //Add new lecturer
                                    if (chonn == 1)
                                    {
                                        Console.WriteLine("Let add a new lecturer");
                                        Console.WriteLine("=====================");
                                        Console.Write("Input Lecturer's id: ");
                                        string id = Console.ReadLine();
                                        //check the number of characters entered 
                                        const int idMax = 3;
                                        if (id.Length > idMax)
                                        {
                                            id = id.Substring(0, idMax);
                                            Console.WriteLine("*Id has been cut to 3 characters!\n");
                                        }
                                        Console.Write("Input lecturer's Batch: ");
                                        string batch = Console.ReadLine();
                                        Console.Write("Input Lecturer's name: ");
                                        string name = Console.ReadLine();
                                        Console.Write("Input Date of birth: ");
                                        DateTime dob = DateTime.Parse(Console.ReadLine());
                                        Console.Write("Input lecturer's Address: ");
                                        string add = Console.ReadLine();
                                        Console.Write("Input lecturer's Mail: ");
                                        string mail = Console.ReadLine();


                                        List_lec.Add(new Lecturer(id, batch, name, dob, mail, add));
                                        Console.WriteLine("\nAdded a new lecturer Successfully !");
                                    }
                                    //view lecturer
                                    else if (chonn == 2)
                                    {
                                        Console.WriteLine("\n===* List all of Lecturer *===\n");
                                        foreach (Lecturer lect in List_lec)
                                        {
                                            Console.WriteLine(lect.displayLec());
                                            Console.WriteLine("-----------------------------");
                                        }
                                    }
                                    // update lecturer
                                    else if (chonn == 3)
                                    {
                                        Console.WriteLine("Update Lecturer profile");
                                        Console.WriteLine("=========================\n");
                                        Console.Write("Input lecturer's Id that you want to update: ");
                                        string UpdateById = Console.ReadLine();
                                        Lecturer updateLecturer = List_lec.Find(x => x.lecId.Equals(UpdateById));
                                        if (updateLecturer == null)
                                            Console.WriteLine("Can not find the lecturer!");
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Update a new Lecturer");
                                            Console.WriteLine("=====================\n");

                                            Console.Write("Name update: ");
                                            updateLecturer.name = Console.ReadLine();
                                            Console.Write("Dob update: ");
                                            updateLecturer.dob = DateTime.Parse(Console.ReadLine());
                                            Console.Write("Address update: ");
                                            updateLecturer.address = Console.ReadLine();
                                            Console.Write("Mail update: ");
                                            updateLecturer.email = Console.ReadLine();
                                            Console.Write("Batch update: ");
                                            updateLecturer.lecBatch = Console.ReadLine();

                                            Console.WriteLine("\nUpdate lecturer Successfully!");
                                        }
                                    }
                                    //delete lecturer
                                    else if (chonn == 4)
                                    {
                                        Console.WriteLine("Delete a Lecturer");
                                        Console.WriteLine("====================\n");
                                        Console.Write("Input lecturer's id that you want to delete:");
                                        string DeleteById = Console.ReadLine();
                                        Lecturer deleteLecturer = List_lec.Find(x => x.lecId.Equals(DeleteById));
                                        if (deleteLecturer == null)
                                            Console.WriteLine("Can not find the lecturer!");
                                        else
                                        {
                                            List_lec.Remove(deleteLecturer);
                                            Console.WriteLine("Removed lecturer Successfully!");
                                        }
                                    }
                                    //search lecturers
                                    else if (chonn == 5)
                                    {
                                        Console.WriteLine("Searching for Lecturer");
                                        Console.WriteLine("=======================\n");
                                        Console.Write("Enter Lecturer's id: ");
                                        string SearchByNameOrId = Console.ReadLine();
                                        Lecturer SearchLecturer = List_lec.Find(x => x.name.Contains(SearchByNameOrId) || x.lecId.Equals(SearchByNameOrId));

                                       
                                        Console.WriteLine("Show searched Lecturer: \n");
                                        Console.WriteLine(SearchLecturer.displayLec());
                                        Console.WriteLine("---------------------------------");
                                    }
                                    else if (chonn == 6)
                                    { break; }


                                }
                                catch
                                {
                                    Console.WriteLine("Notification: Please check the input data!");
                                        
                                }
                            }

                            Console.Clear();
                            break;
                        //case 3: exit program
                        case 3: Environment.Exit(0); break;
                        default: Console.WriteLine("Notification: Please check the input data!\n"); break;


                    }

                    
                }
                catch
                {
                    Console.WriteLine("No function for your choosen! Press 0 to continue");
                    int tt = int.Parse(Console.ReadLine());
                    if (tt == 0) { Console.Clear(); }
                }
            }

            //************************************************************************
        
        }
    }
}
