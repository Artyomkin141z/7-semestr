using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    /*public class Programmers
    {
        public List<Programmer> workers = new List<Programmer>()
        {
            new Programmer("Гилимович Артем", 22, 2, "Инженер-программист", "Juniot")
        };
    }*/
    public class Worker
    {
        private string name = "", img="", about="";
        private int age = 0, workExperience = 0;
        public Worker(string name, int age, int workExperience)
        {
            this.name = name;
            this.age = age;
            this.workExperience = workExperience;
        }
        //методы-свойства и индексаторы
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public string Img
        {
            get { return img; }
            set
            {
                img = value;
            }
        }
        public string About
        {
            get { return about; }
            set { about = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int WorkExperience
        {
            get { return workExperience; }
            set { workExperience = value; }
        }
        //виртуальный метод
        public virtual void work()
        {
            Console.WriteLine("{0} работает", this.name);
        }
    }
    //интерфейс
    public interface IJunior
    {
        void readDocumentation(string doc);
        void learnEnglish();
    }
    public class Programmer : Worker
    {
        private string jobTitle = "", knowledgeLevel = "";
        public Programmer(string name, int age, int workExperience, string jobTitle, string knowledgeLevel)
            : base(name, age, workExperience)
        {
            this.jobTitle = jobTitle;
            this.knowledgeLevel = knowledgeLevel;
        }
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public string KnowledgeLevel
        {
            get { return knowledgeLevel; }
            set { knowledgeLevel = value; }
        }

        public override void work()
        {
            Console.WriteLine("{0} {1} работает и он {2}", this.JobTitle, this.Name, this.KnowledgeLevel);
        }
    }
    //класс наследник
    /*class ProgrammerJunior : Programmer, IJunior
    {
        private string knowledgeLevel = "";
        public ProgrammerJunior(string name, int age, int workExperience, string jobTitle, string knowledgeLevel)
            : base(name, age, workExperience, jobTitle)
        {
            this.knowledgeLevel = knowledgeLevel;
        }
        //методы-свойства и индексаторы
        public string KnowledgeLevel
        {
            get { return knowledgeLevel; }
            set { knowledgeLevel = value; }
        }
        //переопределение виртуального метода
        void IJunior.readDocumentation(string doc)
        {
            Console.WriteLine("{0} пошел читать документацию по {1}", this.Name, doc);
        }
        void IJunior.learnEnglish()
        {
            Console.WriteLine("{0} учит английский", this.Name);
        }
    }*/
    class Test : Worker
    {
        private string jobTitle = "";
        public Test(string name, int age, int workExperience, string jobTitle)
            : base(name, age, workExperience)
        {
            try
            {
                if (jobTitle == "programmer")
                {
                    throw new Exception(message: "Вы пытаетесь создать программиста через класс Test для этого есть специальный класс Programer");
                }
                else this.jobTitle = jobTitle;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            this.jobTitle = jobTitle;
        }
        public string JobTitle
        {
            get { return jobTitle; }
        }
    }
}
