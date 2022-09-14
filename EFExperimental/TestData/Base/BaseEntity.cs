using System.ComponentModel.DataAnnotations;

namespace EFExperimental.TestData.Base
{
    public class BaseEntity<K>
    {
        [Key]
        public K Id { get; set; }
    }
}
