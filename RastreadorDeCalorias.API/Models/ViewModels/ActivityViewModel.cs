namespace RastreadorDeCalorias.API.Models.ViewModels
{
    public class ActivityViewModel
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public TimeSpan Duration { get; set; }
        public double Distance { get; set; }
        public double CaloriesBurned { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
    }
}
