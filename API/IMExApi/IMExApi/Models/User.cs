using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace IMExApi.Models
{
    public class User
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "User Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Id_OPU")]
        [ForeignKey("OPU")]
        [Display(Name = "User OPU Id")]
        public Guid Id_OPU { get; set; }

        [Required]
        [Column("Id_Role")]
        [ForeignKey("Role")]
        [Display(Name = "User Role Id")]
        public Guid Id_Role { get; set; }

        [Required]
        [StringLength(20)]
        [Column("FirstName")]
        [Display(Name = "User First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        [Column("LastName")]
        [Display(Name = "User Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(30)]
        [Column("UserName")]
        [Display(Name = "User Login Name")]
        public string UserName { get; set; }

        [Required]
        [Column("UserPassword")]
        [Display(Name = "User Login Password Hash")]
        public string Password { get; set; }

        [Required]
        [Column("DateValidStart")]
        [Display(Name = "Validity Start Date")]
        public DateTime DateValidStart { get; set; }

        [Required]
        [Column("DateValidEnd")]
        [Display(Name = "Validity End Date")]
        public DateTime DateValidEnd { get; set; }

        [Required]
        [Column("IsActive")]
        [DefaultValue("True")]
        [Display(Name = "Equipment Active Flag")]
        public bool Active { get; set; }

        [Required]
        [Column("Id_CreatedBy")]
        [Display(Name = "User Created By Id")]
        public Guid Id_CreatedBy { get; set; }

        [Required]
        [Column("DateCreated")]
        [Display(Name = "User Date Created")]
        public DateTime DateCreated { get; set; }

        [Column("Id_UpdatedBy")]
        [Display(Name = "User Updated By Id")]
        public Guid Id_UpdatedBy { get; set; }

        [Column("DateUpdated")]
        [Display(Name = "User Date Updated")]
        public DateTime DateUpdated { get; set; }

        [Column("Id_DeletedBy")]
        [Display(Name = "User Deleted By Id")]
        public Guid Id_DeletedBy { get; set; }

        [Column("DateDeleted")]
        [Display(Name = "User Date Deleted")]
        public DateTime DateDeleted { get; set; }

        #endregion

        #region Collections

        public OPU OPU { get; set; }
        public Role Role { get; set; }

        public ICollection<Inspection> Inspections { get; set; }

        #endregion
    }
}
