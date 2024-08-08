namespace RastreadorDeCalorias.API.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() 
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; private set; }
    }
}
