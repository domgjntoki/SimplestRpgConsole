namespace RpgConsole.Entities;

public class Wizard : Hero
{
    public Wizard(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
    {
    }

    public Wizard()
    {
        
    }

    public override string Attack()
    {
        return $"{Name} attacked with their spells";
    }
    
    public  string Attack(int bonus)
    {
        if (bonus > 6)
        {
            return $"{Name} attacked with their spells with a bonus of {bonus}. (Super effective)";
        }
        else
        {
            return $"{Name} attacked with their spells with a bonus of {bonus}. (Not effective)";
        }
        
    }
}