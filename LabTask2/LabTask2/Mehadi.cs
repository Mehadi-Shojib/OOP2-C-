using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask2
{
    class Mehadi
    {
        //attributes witth all the access modifiers
        public string name;
        protected string id;
        private float cgpa;
        internal int semester;
        protected internal string program;
        string university;
        //Default constructor
        public Mehadi()
        {
            Console.WriteLine("-----Default Constructor-----");
        }
        //static constructor
        static Mehadi()
        {
            Console.WriteLine("-----Static Constructor-----");
            Console.WriteLine();
        }
        //Parameterized constructor
        public Mehadi(string name, string id, float cgpa, int semester, string program, string university)
        {
            Console.WriteLine("----Parameterized Constructor----");

            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            this.semester = semester;
            this.program = program;
            this.university = university;
        }
        //Copy Constructor
        public Mehadi(Mehadi m)
        {
            Console.WriteLine("-----Copy Constructor-----");
            name = m.name;
            id = m.id;
            cgpa = m.cgpa;
            semester = m.semester;
            program = m.program;
            university = m.university;

        }
        //ALl the setter methods
        public void setName(string name)
        {
            this.name = name;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public void setCgpa(float cgpa)
        {
            this.cgpa = cgpa;
        }
        public void setSemester(int semester)
        {
            this.semester = semester;

        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public void setUniversity(string university)
        {
            this.university = university;
        }
        //all the getter methods
        public string getName()
        {
            return name;
        }
        public string getId()
        {
            return id;
        }
        public float getCgpa()
        {
            return cgpa;
        }
        public int getSemester()
        {
            return semester;
        }
        public string getProgram()
        {
            return program;
        }
        public string getUniversity()
        {
            return university;
        }
        //show information method
        public void show()
        {
            Console.WriteLine("Name = " + name);
            Console.WriteLine("ID = " + id);
            Console.WriteLine("cgpa = " + cgpa);
            Console.WriteLine("Semester = " + semester);
            Console.WriteLine("Program = " + program);
            Console.WriteLine("University = " + university);
        }

    }
}
