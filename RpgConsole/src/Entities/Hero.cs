namespace RpgConsole.Entities;

public abstract class Hero
{
    public string Name;

    public int Level;

    public string HeroType;

    public int Hp;

    public int Mp;


    protected Hero(string name, int level, string heroType, int hp, int mp)
    {
        Name = name;
        Level = level;
        HeroType = heroType;
        Hp = hp;
        Mp = mp;
    }

    public Hero()
    {
        
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Level)}: {Level}, " +
               $"{nameof(HeroType)}: {HeroType}, {nameof(Hp)}: {Hp}, {nameof(Mp)}: {Mp}";
    }

    public abstract string Attack();
}