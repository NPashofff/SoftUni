namespace Raiding
{
    public abstract class BaseHero
    {       
        public BaseHero(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public int Power { get; protected set; }

        public virtual string CastAbility()
        {
            return $"{GetType().Name} - {Name}";
        }

    }
}
