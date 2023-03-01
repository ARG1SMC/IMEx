using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMExApi.Models
{
    public class InspectionEquipment
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Inspection Equipment Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Id_Inspection")]
        [ForeignKey("Inspection")]
        [Display(Name = "Inspection Equipment Inspection Id")]
        public Guid Id_Inspection { get; set; }

        [Required]
        [Column("Id_Risk")]
        [ForeignKey("Risk")]
        [Display(Name = "Inspection Equipment Risk Id")]
        public Guid Id_Risk { get; set; }

        [Required]
        [StringLength(100)]
        [Column("OPU")]
        [Display(Name = "Inspection Equipment OPU")]
        public string OPU { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Platform")]
        [Display(Name = "Inspection Equipment Platform")]
        public string Platform { get; set; }

        [Required]
        [StringLength(100)]
        [Column("LocationOne")]
        [Display(Name = "Inspection Equipment Location One")]
        public string LocationOne { get; set; }

        [Required]
        [StringLength(100)]
        [Column("LocationTwo")]
        [Display(Name = "Inspection Equipment Location Two")]
        public string LocationTwo { get; set; }

        [Required]
        [StringLength(100)]
        [Column("HACDwgNo")]
        [Display(Name = "Inspection Equipment HAC Drawing No")]
        public string HACDwgNo { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Coordinate")]
        [Display(Name = "Inspection Equipment Coordinate")]
        public string Coordinate { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Zone")]
        [Display(Name = "Inspection Equipment Zone")]
        public string Zone { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Purpose")]
        [Display(Name = "Inspection Equipment Purpose")]
        public string Purpose { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Manufacturer")]
        [Display(Name = "Inspection Equipment Manufacturer")]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Model")]
        [Display(Name = "Inspection Equipment Model")]
        public string Model { get; set; }

        [Required]
        [StringLength(100)]
        [Column("SerialNo")]
        [Display(Name = "Inspection Equipment SerialNo")]
        public string SerialNo { get; set; }

        [Required]
        [StringLength(100)]
        [Column("IECExCertificateAuthority")]
        [Display(Name = "Inspection Equipment IEC Ex Certificate Authority")]
        public string IECExCertificateAuthority { get; set; }

        [Required]
        [StringLength(100)]
        [Column("IECExCertificateCategory")]
        [Display(Name = "Inspection Equipment IEC Ex Certificate Category")]
        public string IECExCertificateCategory { get; set; }

        [Required]
        [StringLength(100)]
        [Column("IECExCertificateNo")]
        [Display(Name = "Inspection Equipment IEC Ex Certificate No")]
        public string IECExCertificateNo { get; set; }

        [Required]
        [StringLength(100)]
        [Column("IECExCertificateDetail")]
        [Display(Name = "Inspection Equipment IEC Ex Certificate Detail")]
        public string IECExCertificateDetail { get; set; }

        [Required]
        [StringLength(100)]
        [Column("ElectricalRating")]
        [Display(Name = "Inspection Equipment Electrical Rating")]
        public string ElectricalRating { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Discipline")]
        [Display(Name = "Inspection Equipment Discipline")]
        public string Discipline { get; set; }

        [Required]
        [StringLength(100)]
        [Column("ProtectionType")]
        [Display(Name = "Inspection Equipment Protection Type")]
        public string ProtectionType { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Name")]
        [Display(Name = "Inspection Equipment Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [Column("TagNo")]
        [Display(Name = "Inspection Equipment Tag No")]
        public string TagNo { get; set; }

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

        public Inspection Inspection { get; set; }
        public Risk Risk { get; set; }

        #endregion
    }
}
