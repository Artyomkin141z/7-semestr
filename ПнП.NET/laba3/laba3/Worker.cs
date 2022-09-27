using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    internal class Worker
    {
        private string name = "";
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
    class Programmer : Worker
    {
        private string jobTitle = "";
        public Programmer(string name, int age, int workExperience, string jobTitle)
            : base(name, age, workExperience)
        {
            this.jobTitle = jobTitle;
        }
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }
    }
    //класс наследник
    class ProgrammerJunior : Programmer, IJunior
    {
        private string jobTitle = "", knowledgeLevel = "";
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
        public override void work()
        {
            Console.WriteLine("{0} {1} работает и он {2}", this.JobTitle, this.Name, this.KnowledgeLevel);
        }
        void IJunior.readDocumentation(string doc)
        {
            Console.WriteLine("{0} пошел читать документацию по {1}", this.Name, doc);
        }
        void IJunior.learnEnglish()
        {
            Console.WriteLine("{0} учит английский", this.Name);
        }
    }
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
