using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMExApi.Models
{
    public class Role
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Role Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Code")]
        [StringLength(30)]
        [Display(Name = "Role Code")]
        public string Code { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Role Name")]
        public string Name { get; set; }

        [Required]
        [Column("Description")]
        [StringLength(60)]
        [Display(Name = "Role Description")]
        public string Description { get; set; }

        #endregion

        #region Collections

        public ICollection<User> Users { get; set; }

        #endregion
    }
}
