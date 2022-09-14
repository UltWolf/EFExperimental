using EFExperimental.TestData.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFExperimental.TestData
{
    public class TestParent:BaseEntity<long>
    {
        public string ParentTextValue { get; set; }
        public long ChildId { get; set; }
        [ForeignKey(nameof(ChildId))]
        public TestChild TestChild { get; set; }
    }
}
