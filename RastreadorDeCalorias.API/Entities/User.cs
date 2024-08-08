using Microsoft.AspNetCore.Identity;

namespace RastreadorDeCalorias.API.Entities
{
    public class User : IdentityUser
    {
        public User(string firstName, string lastName) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Activities = new List<Activity>();
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public ICollection<Activity> Activities { get; private set; }
    }
}
