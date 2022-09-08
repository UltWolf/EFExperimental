using EFExperimental.TestData.Base;

namespace EFExperimental.TestData
{
    public class TestParent:BaseEntity<long>
    {
        public string ParentTextValue { get; set; }
        public long ChildId { get; set; }
        public TestChild TestChild { get; set; }
    }
}
