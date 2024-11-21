

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorCRUDApp.Domain.Entities
{
    public class Students
    {
        // ID, Name string, DataOfBirth datetime, Weight int, Graduated bool


        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        public DateTime? DataOfBirth { get; set; }
        public int Weight { get; set; }
        public bool Graduated { get; set; } = false;


    }
}
