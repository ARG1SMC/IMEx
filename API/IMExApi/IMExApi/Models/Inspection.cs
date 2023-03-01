using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMExApi.Models
{
    public class Inspection
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Inspection Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Id_OPU")]
        [ForeignKey("OPU")]
        [Display(Name = "Inspection OPU Id")]
        public Guid Id_OPU { get; set; }

        [Required]
        [Column("Id_Platform")]
        [ForeignKey("Platform")]
        [Display(Name = "Inspection Platform Id")]
        public Guid Id_Platform { get; set; }

        [Required]
        [Column("Id_Discipline")]
        [ForeignKey("Discipline")]
        [Display(Name = "Inspection Discipline Id")]
        public Guid Id_Discipline { get; set; }

        [Required]
        [Column("Id_User")]
        [ForeignKey("User")]
        [Display(Name = "Inspection User Id")]
        public Guid Id_User { get; set; }

        [Required]
        [Column("Id_InspectionType")]
        [ForeignKey("InspectionType")]
        [Display(Name = "Inspection Inspection Type Id")]
        public Guid Id_InspectionType { get; set; }

        [Required]
        [StringLength(80)]
        [Column("Name")]
        [Display(Name = "Inspection Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        [Column("Description")]
        [Display(Name = "Inspection Description")]
        public string Description { get; set; }

        [Required]
        [Column("DateInspectionStart")]
        [Display(Name = "Inspection Start Date")]
        public DateTime DateInspectionStart { get; set; }

        [Required]
        [Column("DateInspectionEnd")]
        [Display(Name = "Inspection End Date")]
        public DateTime DateInspectionEnd { get; set; }

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
        public Platform Platform { get; set; }
        public Discipline Discipline { get; set; }
        public User User { get; set; }
        public InspectionType InspectionType { get; set; }

        public ICollection<InspectionEquipment> InspectionEquipments { get; set; }

        #endregion
    }
}
