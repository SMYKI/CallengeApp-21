namespace ChallengeApp_21.tests
{
    public class Tests
    {
        [Test]
        public void WhenAddThreeDifferentValues_ShouldGetCorrectResult()
        {
            var employee = new Employee("Jurek", "Lover", 23);
            employee.AddPoint(5);
            employee.AddPoint(5);
            employee.AddPoint(-10);

            var Result = employee.Result;

            Assert.AreEqual(0, employee.Result);

        }

        [Test]
        public void WhenAddThreeItems_ShoultGetCorrectResult()
        {
            var employee = new Employee("Laura", "Kowalska", 33);
            employee.AddPoint(1);
            employee.AddPoint(1);
            employee.AddPoint(1);

            var Result = employee.Result;

            Assert.AreEqual(3, employee.Result);
        }

        [Test]
        public void WhenAddPoints_ShouldGetCorrectResult()
        {
            var employee = new Employee("Irek", "Nowak", 50);
            employee.AddPoint(-8);
            employee.AddPoint(3);
            employee.AddPoint(3);

            var Result = employee.Result;

            Assert.AreEqual(-2, employee.Result);
        }
    }
 }