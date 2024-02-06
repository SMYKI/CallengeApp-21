namespace ChallengeApp_21.tests
{    public class TypeTests
    {   [Test]
        public void Test_CheckAgeValues_DifferentOrNot()
        {
            int AgeEmoloyee1 = 28;
            int AgeEmployee2 = 32;

            Assert.AreNotEqual(AgeEmoloyee1, AgeEmployee2);
        }
        [Test]
        public void Test_CheckValuesOfTwoYears_AreDifferentOrNot()
        {
            int Year1 = 2024;
            int Year2 = 2024;

            Assert.AreEqual(Year1, Year2);
        }
        [Test]
        public void Test_CheckTwoNick_AreSameOrNot()
        {
            string MyNick1 = "Smyki";
            string MyNick2 = "Smyki";

            Assert.AreEqual(MyNick1, MyNick2);
        }
        [Test]
        public void Test_ComparsionOfTemperature_AreEqualOrNot()
        {
            float AirTemperature1 = 28.5F;
            float AirTemperature2 = 150.125F;

            Assert.AreNotEqual(AirTemperature1, AirTemperature2);
        }
    }
}
