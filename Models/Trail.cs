using System.ComponentModel.DataAnnotations;

namespace TatryExplorer.Models
{
    public class Trail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Nazwa Trasy")]
        public double LengthKm { get; set; }
        [Display(Name = "Długość trasy")]
        public TimeSpan TimeToComplete { get; set; }
        [Display(Name = "Czas ukończenia")]
        public TimeSpan Duration { get; set; }
        public string DifficultyLevel { get; set; }
        [Display(Name = "Poziom trudności")]
        public string MapLink { get; set; }
        [Display(Name = "Zobacz na mapie")]
        public string Description { get; set; }
        [Display(Name = "Opis")]
        public string Image { get; set; }
        [Display(Name = "Zdjęcie")]

        public string Photo { get; set; }
    }
}