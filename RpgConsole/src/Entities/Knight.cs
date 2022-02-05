namespace RpgConsole.Entities;

public class Knight: Hero
{
    public Knight(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
    {
    }

    public Knight()
    {
        
    }
    
    public override string Attack()
    {
        return $"{Name} attacked with their sword.";
    }
}