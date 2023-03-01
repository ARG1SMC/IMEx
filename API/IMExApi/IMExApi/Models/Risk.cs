using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMExApi.Models
{
    public class Risk
    {
        #region Field Definition

        [Key]
        [Column("Id")]
        [Display(Name = "Risk Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [StringLength(30)]
        [Display(Name = "Risk Name")]
        public string Name { get; set; }

        [Required]
        [Column("Description")]
        [StringLength(60)]
        [Display(Name = "Risk Description")]
        public string Description { get; set; }

        #endregion

        #region Collections

        public ICollection<InspectionEquipment> InspectionEquipments { get; set; }

        #endregion
    }
}
