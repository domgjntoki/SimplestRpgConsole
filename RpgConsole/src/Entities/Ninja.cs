namespace RpgConsole.Entities;

public class Ninja : Hero
{
    public Ninja()
    {
    }

    public Ninja(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
    {
    }

    public override string Attack()
    {
        return $"{Name} attacked with his daggers.";
    }

    public string Attack(bool isSneak)
    {
        return isSneak ? $"{Name} made a stealth attack! (Very effective)" : Attack();
    }
}