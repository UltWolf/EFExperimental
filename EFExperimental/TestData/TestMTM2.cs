using EFExperimental.TestData.Base;

namespace EFExperimental.TestData
{
    public class TestMTM2:BaseEntity<long>
    {
        public string TestMTM2TextValue { get; set; }
        public ICollection<TestMTM1> TestMTM1s { get; set; }
    } 
}
