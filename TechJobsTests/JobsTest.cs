using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    class JobsTest
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
            Assert.IsTrue(job1.Id != job2.Id && (job1.Id + 1) == job2.Id);
        }

        class ClassToTest
        {
            public int Id;
            public string Name;
            public Employer EmployerName; 
            public Location EmployerLocation;
            public PositionType JobType; 
            public CoreCompetency JobCoreCompetency;
            private int nextId;

            public ClassToTest(int Id, string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)
            {
                Id = nextId;
                Name = "Product tester";
                EmployerName = "ACME";                   ''
                EmployerLocation = "Desert";
                JobType = "Quality control";
                JobCoreCompetency = "Persistence";
            }
        }

        //TEST FULL CONSTRUCTOR Use Assert statements to test that the constructor correctly assigns the value of each field
    }
}