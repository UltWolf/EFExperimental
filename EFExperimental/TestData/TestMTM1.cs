using EFExperimental.TestData.Base;

namespace EFExperimental.TestData
{
    public class TestMTM1:BaseEntity<long>
    {
        public string TestMTM1TextValue { get; set; }
        public ICollection<TestMTM2> TestMTM2s { get; set; }
    }
}
