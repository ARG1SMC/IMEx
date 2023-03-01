using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMExApi.Models
{
    public class Business
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Business Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Business Name")]
        public string Name { get; set; }

        [Required]
        [Column("Description")]
        [StringLength(60)]
        [Display(Name = "Business Description")]
        public string Description { get; set; }

        #endregion

        #region Collections

        public ICollection<OPU> OPU { get; set; }

        #endregion
    }

    public class Region
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Region/Segment Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Region/Segment Name")]
        public string Name { get; set; }

        [Required]
        [Column("Description")]
        [StringLength(60)]
        [Display(Name = "Region/Segment Description")]
        public string Description { get; set; }

        #endregion

        #region Collections

        public ICollection<OPU> OPU { get; set; }

        #endregion
    }

    public class Field
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Field/Plant Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Field/Plant Name")]
        public string Name { get; set; }

        [Required]
        [Column("Description")]
        [StringLength(60)]
        [Display(Name = "Field/Plant Description")]
        public string Description { get; set; }

        #endregion

        #region Collections

        public ICollection<OPU> OPU { get; set; }

        #endregion
    }

    public class OPU
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "OPU Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Id_Business")]
        [ForeignKey("Business")]
        [Display(Name = "OPU Business Id")]
        public Guid Id_Business { get; set; }

        [Required]
        [Column("Id_Region")]
        [ForeignKey("Region")]
        [Display(Name = "OPU Region/Segment Id")]
        public Guid Id_Region { get; set; }

        [Required]
        [Column("Id_Field")]
        [ForeignKey("Field")]
        [Display(Name = "OPU Field/Plant Id")]
        public Guid Id_Field { get; set; }

        #endregion

        #region Collections

        public Business Business { get; set; }
        public Region Region { get; set; }
        public Field Field { get; set; }

        public ICollection<Equipment> Equipments { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Inspection> Inspections { get; set; }

        #endregion
    }
}
