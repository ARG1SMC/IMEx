using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMExApi.Models
{
    public class InspectionType
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Inspection Type Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Inspection Type Name")]
        public string Name { get; set; }

        [Required]
        [Column("Description")]
        [StringLength(60)]
        [Display(Name = "Inspection Type Description")]
        public string Description { get; set; }

        #endregion

        #region Collections

        public ICollection<Inspection> Inspections { get; set; }

        #endregion
    }
}
