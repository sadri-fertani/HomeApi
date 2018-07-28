using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Waterman.DataAccess.POCO
{
    [Table("t_Todo", Schema = "watermanschema")]
    public class Todo
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }
    }
}