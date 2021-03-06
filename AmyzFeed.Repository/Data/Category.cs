using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmyzFeed.Repository.Data
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int DepartmentID { get; set; }
        public string Image { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        public Nullable<DateTime> UpdatedDate { get; set; }
        [Required]
        public bool Visibility { get; set; }
        [Required]
        public bool IsDeleted { get; set; }


        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }

       public IEnumerable<Product> Products { get; set;}
    }
}
