public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int CurrentXP { get; private set; }
    public int MaxXP { get; private set; }
    public int Coins { get; private set; }

    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int HP { get; private set; }
    public int Critical { get; private set; }

    public Character(string name, int level, int currentHP, int maxHP, int coins,
                     int attack, int defense, int hp, int critical)
    {
        Name = name;
        Level = level;
        CurrentXP = currentHP;
        MaxXP = maxHP;
        Coins = coins;
        Attack = attack;
        Defense = defense;
        HP = hp;
        Critical = critical;
    }
}