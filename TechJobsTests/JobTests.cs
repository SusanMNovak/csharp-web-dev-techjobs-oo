using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobsTest
    {
        Job job1;
        Job job2;
        Job job3;
        Job job4;

        [TestInitialize]
        public void CreateJobObjects()
        {
            job1 = new Job();
            job2 = new Job();
            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsTrue(job1.Id != job3.Id);
        }

        //TEST FULL CONSTRUCTOR Use Assert statements to test that the constructor correctly assigns the value of each field
        [TestMethod]
        public void FullConstructorTest()
        {
            Assert.IsTrue("Product tester" == job3.Name);
            Assert.IsTrue("ACME" == job3.EmployerName.Value);
            Assert.IsTrue("Desert" == job3.EmployerLocation.Value);
            Assert.IsTrue("Quality control" == job3.JobType.Value);
            Assert.IsTrue("Persistence" == job3.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality() 
        {
            Assert.IsTrue(job4.Id == job3.Id);
            Assert.IsTrue(job4.Name == job3.Name);
            Assert.IsTrue(job4.EmployerName.Value == job3.EmployerName.Value);
            Assert.IsTrue(job4.EmployerLocation.Value == job3.EmployerLocation.Value);
            Assert.IsTrue(job4.JobType.Value == job3.JobType.Value);
            Assert.IsTrue(job4.JobCoreCompetency.Value == job3.JobCoreCompetency.Value);
        }
        //Use TDD to Build The ToString() Method
        [TestMethod]
        public void TestToString()
        {
            Assert.IsTrue(jobi.IobCoreCompetency.Value"");
            Assert.IsTrue("Name: " + jobi.Name + \n + "Employer: " + jobi.EmployerName.Value + \n + "Location: " + "jobi.EmployerLocation.Value" + \n + " Position Type: " jobi.JobType.Value + \n + "Core Competency: " + "jobi.JobCoreCompetency.Value" + \n;)
        }   Assert.IsNullOrEmpty(Job);

    }






}