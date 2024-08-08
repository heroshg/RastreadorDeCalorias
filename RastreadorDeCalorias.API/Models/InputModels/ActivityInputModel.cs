namespace RastreadorDeCalorias.API.Models.InputModels
{
    public class ActivityInputModel
    {
        public string Type { get; set; }
        public TimeSpan Duration { get; set; }
        public double Distance { get; set; }
        public double CaloriesBurned { get; set; }
        public DateTime Date { get; set; }
    }
}
