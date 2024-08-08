using RastreadorDeCalorias.API.Enums;

namespace RastreadorDeCalorias.API.Entities
{
    public class Activity : EntityBase
    {
        public Activity(ActivityType type, TimeSpan duration, double distance, double caloriesBurned, DateTime date, string userId) : base() 
        {
            Type = type;
            Duration = duration;
            Distance = distance;
            CaloriesBurned = caloriesBurned;
            Date = date;
            UserId = userId;
        }
        public ActivityType Type { get; private set; }
        public TimeSpan Duration { get; private set; }
        public double Distance { get; private set; }
        public double CaloriesBurned { get; private set; }
        public DateTime Date { get; private set; }
        public string UserId { get; private set; }
        public User User { get; private set; }

        public void Update(ActivityType type, TimeSpan duration, double distance, double caloriesBurned)
        {
            this.Type = type;
            this.Duration = duration;
            this.Distance = distance;
            this.CaloriesBurned = caloriesBurned;
        }
    }
}
