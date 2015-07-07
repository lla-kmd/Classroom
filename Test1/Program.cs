﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region create students
            Student stud1 = new Student("Per",  "Olsen", 1);
            Student stud2 = new Student("Knud", "Petersen", 1, "lol@lol.dk");
            Student stud3 = new Student("Asger", "Hansen", 2);
            Student stud4 = new Student("Line", "Jensen", 2);
            #endregion

            #region create teachers
            Teacher teach1 = new Teacher("Hans", "Hansen");
            Teacher teach2 = new Teacher("Knud", "Poulsen");
            #endregion

            #region create classes
            ClassDef MathClass = new ClassDef("Math", 2);
            ClassDef ChemistryClass = new ClassDef("Chemistry", 1);
            #endregion

            MathClass.GoalReached += (s, e) => Console.WriteLine("MathClass has enough members now, ({0}/{0})", MathClass.MinAttendants);

            MathClass.AddTeacherToClass(teach1);
            MathClass.AddTeacherToClass(teach2);

            MathClass.AddStudentToClass(stud1);
            MathClass.AddStudentToClass(stud2);
            MathClass.AddStudentToClass(stud3);

            ChemistryClass.AddStudentToClass(stud1);

            Console.WriteLine("Students in MathClass are: ");
            foreach (var student in MathClass.Students)
            {
                Console.WriteLine(student.FirstName);
            }

            Console.WriteLine("Mathclass has {0} teachers", MathClass.Hosts.Count);
            Console.WriteLine("ChemistryClass has {0} teachers", ChemistryClass.Hosts.Count);

            Console.Read();
        }
    }
}
