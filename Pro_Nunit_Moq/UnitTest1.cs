using Moq;
using School;

namespace Pro_Nunit_Moq
{
    [TestFixture]
    public class Tests
    {
        SchoolMng1 SchMng;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TeacherNullTest()
        {
            foreach(var s in SchoolMng1.AllTeachers())
            {
                Assert.IsNotNull(s.Tid);
                Assert.IsNotNull(s.TeacherName);
            }
        }
        [Test]
        public void studentNull()
        {
            int RollNumber = 1;
            Assert.IsNotNull(SchoolMng1.StudentById(RollNumber));
        }
        [Test]
        public void MoqTeacherName()
        {
            var Tname = new Mock<Teachers>();
            var teacher=Tname.Object;
            Assert.IsNotNull(teacher);
        }
    }
}