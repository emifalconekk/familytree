namespace Library;

public class Person
{
        private string name;
        private int age;

        public string Name
        {
                get { return name; }
        }

        public int Age
        {
                get { return age; }
        }

        public Person(string name, int age)
        {
                this.age = age;
                this.name = name;
        }
}