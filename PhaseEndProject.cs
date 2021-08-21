using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class teacher
    {
        public int ID { get; set; }
        public int Class  { get; set; }
        public string Section { get; set; }
        public string Tname { get; set; }
    }
    class teacherBO
    {
       public List<teacher> teachers;
        public teacherBO()
        { 
            teachers = new List<teacher>() 
            {
            new teacher{ ID=1 , Class = 1 , Section= "A", Tname="Shreenidhi"},
            new teacher{ ID = 2, Class = 2, Section = "C", Tname = "Vinay" },
            new teacher{ ID = 3, Class = 3, Section = "D", Tname = "Revanth" },
            new teacher{ ID = 4, Class = 4, Section = "B", Tname = "Rahul" },
        };

        }
        public List<teacher> GetTeachers()
        {
            return teachers;
        }
        public void TeacherAdd(teacher t1)
        {
            teachers.Add(t1);
            
        }
        
        public void EditTeachers(int id)
        {
            int index = teachers.FindIndex(x => x.ID == id);
            Console.WriteLine($"Enter the new deatails of teacher {id}");
            
            Console.Write("ID: ");
            int id1 = Convert.ToInt32(Console.ReadLine());
            teachers[index].ID = id1;
            Console.Write("\nname: ");
            string name1 = Console.ReadLine();
            teachers[index].Tname = name1;
            Console.Write("\nClass: ");
            teachers[index].Class = Convert.ToInt32(Console.Read());
            Console.Write("\nSection: ");
            string sec1;
            sec1 = Console.ReadLine();
            teachers[index].Section = sec1;
           
            
        }
        public void DeleteTeachers(int id)
        {
            int index = teachers.FindIndex(x => x.ID == id);
            teachers.RemoveAt(index);

        }
         public teacher GetTeacherbyID(int id)
        {
            return teachers.Find(x => x.ID == id);
        }
    }
    class program62
    {
        static void Main(string[] args)
        {
            teacherBO context = new teacherBO();
            
            while (true)
            {
                Console.Write("\nEnter your choice\n 1. Add teacher \n 2. Display by given ID \n 3. Display teachers " +
                    "\n 4. Delete a teacher \n 5. Update a teacher \n ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: teacher temp = new teacher();
                            Console.Write("\n Enter the name : ");
                        temp.Tname = Console.ReadLine();
                        Console.Write(" \n Enter the ID : ");
                        temp.ID = Convert.ToInt32(Console.ReadLine());
                        Console.Write(" \n Enter the class : ");
                        temp.Class = Convert.ToInt32(Console.ReadLine());
                        Console.Write(" \n Enter the section : ");
                        temp.Section = Console.ReadLine();
                        context.TeacherAdd(temp);
                        break;

                    case 2: Console.Write(" \n Enter the ID : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        teacher dis1 = new teacher();
                        dis1 = context.GetTeacherbyID(id);
                        Console.Write( $"\nName: {dis1.Tname} ID={dis1.ID} Class={dis1.Class} Section={dis1.Section} ");
                        break;

                    case 3: List<teacher> TeacherList = context.GetTeachers();
                        foreach(teacher i in TeacherList)
                            Console.Write($"\n Name={i.Tname} ID={i.ID} Class={i.Class} Section={i.Section}");
                        break;

                    case 4: Console.Write(" \n Enter the ID : ");
                        int delId = Convert.ToInt32(Console.ReadLine());
                        context.DeleteTeachers(delId);
                        break;

                    case 5: Console.Write(" \n Enter the ID : ");
                        int uId = Convert.ToInt32(Console.ReadLine());
                        context.EditTeachers(uId);
                        break;

                    default: Console.WriteLine("invalid input");
                        break;


                }
            }
            
        }
    }
}
