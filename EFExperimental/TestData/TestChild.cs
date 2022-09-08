using EFExperimental.TestData.Base;

namespace EFExperimental.TestData
{
    public class TestChild:BaseEntity<long>
    {
        public string ChildTextValue { get; set; }
        public long ParentId { get; set; }
        public TestParent TestParent{ get; set; }
    }
}
