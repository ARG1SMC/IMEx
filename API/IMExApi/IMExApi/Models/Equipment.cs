using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMExApi.Models
{
    public class Platform
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Platform/Area Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Platform/Area Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }
        public ICollection<Inspection> Inspections { get; set; }

        #endregion
    }

    public class LocationOne
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Location One Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Location One Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class LocationTwo
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Location Two Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Location Two Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class HACDwgNo
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "HAC Dwg No Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "HAC Dwg No Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class Coordinate
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Coordinate Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Coordinate Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class Zone
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Zone Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Zone Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class Purpose
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Purpose/Function Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Purpose/Function Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class Manufacturer
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Manufacturer Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Manufacturer Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class Model
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Model Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Model Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class SerialNo
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Serial No Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(90)]
        [Display(Name = "Serial No Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class IECExCertificateAuthority
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "IEC Ex Certifying Authority Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "IEC Ex Certifying Authority Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class IECExCertificateCategory
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "IEC Ex Certificate Category Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "IEC Ex Certificate Category Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class IECExCertificateNo
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "IEC Ex Certificate No Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("No")]
        [StringLength(30)]
        [Display(Name = "IEC Ex Certificate No No")]
        public string No { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class IECExCertificateDetail
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "IEC Ex Certificate Detail Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("No")]
        [StringLength(30)]
        [Display(Name = "IEC Ex Certificate Detail Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class ElectricalRating
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Electrical Rating Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Electrical Rating Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class Discipline
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Discipline Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Discipline Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }
        public ICollection<Inspection> Inspections { get; set; }

        #endregion
    }

    public class ProtectionType
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Protection Type Id")]
        public Guid Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column("Name")]
        [Display(Name = "Protection Type Name")]
        public string Name { get; set; }

        #endregion

        #region Collections

        public ICollection<Equipment> Equipments { get; set; }

        #endregion
    }

    public class Equipment
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Equipment Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Id_OPU")]
        [ForeignKey("OPU")]
        [Display(Name = "Equipment OPU Id")]
        public Guid Id_OPU { get; set; }

        [Required]
        [Column("Id_Platform")]
        [ForeignKey("Platform")]
        [Display(Name = "Equipment Platform/Area Id")]
        public Guid Id_Platform { get; set; }

        [Required]
        [Column("Id_LocationOne")]
        [ForeignKey("LocationOne")]
        [Display(Name = "Equipment Location One Id")]
        public Guid Id_LocationOne { get; set; }

        [Required]
        [Column("Id_LocationTwo")]
        [ForeignKey("LocationTwo")]
        [Display(Name = "Equipment Location Two Id")]
        public Guid Id_LocationTwo { get; set; }

        [Required]
        [Column("Id_HACDwgNo")]
        [ForeignKey("HACDwgNo")]
        [Display(Name = "Equipment HAC Dwg No Id")]
        public Guid Id_HACDwgNo { get; set; }

        [Required]
        [Column("Id_Coordinate")]
        [ForeignKey("Coordinate")]
        [Display(Name = "Equipment Coordinate Id")]
        public Guid Id_Coordinate { get; set; }

        [Required]
        [Column("Id_Zone")]
        [ForeignKey("Zone")]
        [Display(Name = "Equipment Zone Id")]
        public Guid Id_Zone { get; set; }

        [Required]
        [Column("Id_Purpose")]
        [ForeignKey("Purpose")]
        [Display(Name = "Equipment Purpose Id")]
        public Guid Id_Purpose { get; set; }

        [Required]
        [Column("Id_Manufacturer")]
        [ForeignKey("Manufacturer")]
        [Display(Name = "Equipment Manufacturer Id")]
        public Guid Id_Manufacturer { get; set; }

        [Required]
        [Column("Id_Model")]
        [ForeignKey("Model")]
        [Display(Name = "Equipment Model Id")]
        public Guid Id_Model { get; set; }

        [Required]
        [Column("Id_SerialNo")]
        [ForeignKey("SerialNo")]
        [Display(Name = "Equipment Serial No")]
        public Guid Id_SerialNo { get; set; }

        [Required]
        [Column("Id_IECExCertificateAuthority")]
        [ForeignKey("IECExCertificateAuthority")]
        [Display(Name = "Equipment IEC Ex Certificate Authority Id")]
        public Guid Id_IECExCertificateAuthority { get; set; }

        [Required]
        [Column("Id_IECExCertificateCategory")]
        [ForeignKey("IECExCertificateCategory")]
        [Display(Name = "Equipment IEC Ex Certificate Category Id")]
        public Guid Id_IECExCertificateCategory { get; set; }

        [Required]
        [Column("Id_IECExCertificateNo")]
        [ForeignKey("IECExCertificateNo")]
        [Display(Name = "Equipment IEC Ex Certificate No Id")]
        public Guid Id_IECExCertificateNo { get; set; }

        [Required]
        [Column("Id_IECExCertificateDetail")]
        [ForeignKey("IECExCertificateDetail")]
        [Display(Name = "Equipment IEC Ex Certificate Detail Id")]
        public Guid Id_IECExCertificateDetail { get; set; }

        [Required]
        [Column("Id_ElectricalRating")]
        [ForeignKey("ElectricalRating")]
        [Display(Name = "Equipment Electrical Rating Id")]
        public Guid Id_ElectricalRating { get; set; }

        [Required]
        [Column("Id_Discipline")]
        [ForeignKey("Discipline")]
        [Display(Name = "Equipment Electrical Rating Id")]
        public Guid Id_Discipline { get; set; }

        [Required]
        [Column("Id_ProtectionType")]
        [ForeignKey("ProtectionType")]
        [Display(Name = "Equipment Protection Type Id")]
        public Guid Id_ProtectionType { get; set; }

        [Required]
        [StringLength(30)]
        [Column("Name")]
        [Display(Name = "Equipment Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        [Column("TagNo")]
        [Display(Name = "Equipment Tag No")]
        public string TagNo { get; set; }

        [Required]
        [Column("IsActive")]
        [DefaultValue("True")]
        [Display(Name = "Equipment Active Flag")]
        public bool Active { get; set; }

        [Required]
        [Column("Id_CreatedBy")]
        [Display(Name = "Equipment Created By Id")]
        public Guid Id_CreatedBy { get; set; }

        [Required]
        [Column("DateCreated")]
        [Display(Name = "Equipment Date Created")]
        public DateTime DateCreated { get; set; }


        [Column("Id_UpdatedBy")]
        [Display(Name = "Equipment Updated By Id")]
        public Guid Id_UpdatedBy { get; set; }

        [Column("DateUpdated")]
        [Display(Name = "Equipment Date Updated")]
        public DateTime DateUpdated { get; set; }

        [Column("Id_DeletedBy")]
        [Display(Name = "Equipment Deleted By Id")]
        public Guid Id_DeletedBy { get; set; }

        [Column("DateDeleted")]
        [Display(Name = "Equipment Date Deleted")]
        public DateTime DateDeleted { get; set; }

        #endregion

        #region Collections

        public OPU OPU { get; set; }
        public Platform Platform { get; set; }
        public LocationOne LocationOne { get; set; }
        public LocationTwo LocationTwo { get; set; }
        public HACDwgNo HACDwgNo { get; set; }
        public Coordinate Coordinate { get; set; }
        public Zone Zone { get; set; }
        public Purpose Purpose { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Model Model { get; set; }
        public SerialNo SerialNo { get; set; }
        public IECExCertificateAuthority IECExCertificateAuthority { get; set; }
        public IECExCertificateCategory IECExCertificateCategory { get; set; }
        public IECExCertificateNo IECExCertificateNo { get; set; }
        public IECExCertificateDetail IECExCertificateDetail { get; set; }
        public ElectricalRating ElectricalRating { get; set; }
        public Discipline Discipline { get; set; }
        public ProtectionType ProtectionType { get; set; }

        #endregion
    }
}
