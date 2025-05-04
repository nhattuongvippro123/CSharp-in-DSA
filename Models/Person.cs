namespace Models
{
    public class Person
    {
        private string name;
        private int age;

        //Encapsulation: Properties, tinh dong goi
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine($"{value} is invalid age. Age must be between 0 and 120.");
                }
            }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
        }
    }
}