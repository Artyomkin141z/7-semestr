class Laba2
{
    public static void Main(string[] args)
    {
        Programer jun = new Programer("Artyom", 20, 1, "Junior");
        jun.work();
        IJunior ij = (IJunior)jun;
        ij.readDocumentation("React");
        ij.learnEnglish();
        Test t = new Test("Artyom", 20, 1, "programmer");
        Console.WriteLine(t.Name);
    }
    //абстрактный класс
    abstract class Worker
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
    //класс наследник
    class Programer : Worker, IJunior
    {
        private string jobTitle = "", knowledgeLevel = "";
        public Programer(string name, int age, int workExperience, string knowledgeLevel) 
            : base(name, age, workExperience)
        {
            this.jobTitle = "programmer";
            this.knowledgeLevel = knowledgeLevel;
        }
        //методы-свойства и индексаторы
        public string JobTitle
        {
            get { return jobTitle; }
        }
        public string KnowledgeLevel
        {
            get { return knowledgeLevel; }
            set { knowledgeLevel = value; }
        }
        //переопределение виртуального метода
        public override void work()
        {
            Console.WriteLine("{0} {1} работает и он {2}", this.JobTitle,  this.Name, this.KnowledgeLevel);
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
                if(jobTitle == "programmer")
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

