
namespace ChallengeApp_21
{
    public class Employee
    {
        private List<int> Point = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }


        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return this.Point.Sum();
            }
        }

        public void AddPoint(int point)
        {
            this.Point.Add(point);
        }
    }

}
