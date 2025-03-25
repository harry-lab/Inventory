using UnityEngine;

public enum ItemType
{
    Weapon,
    Armor,
    Helmet,
    Pants,
    Shoes,
    Potion,
    Etc
}

[System.Serializable]
public class Item
{
    public string Name;
    public Sprite Icon;
    public int Count;
    public ItemType Type;

    public int Attack;
    public int Defense;
    public int HP;
    public int Critical;

    public Item(string name, Sprite icon, int count, ItemType type,
                int attack = 0, int defense = 0, int hp = 0, int critical = 0)
    {
        Name = name;
        Icon = icon;
        Count = count;
        Type = type;
        Attack = attack;
        Defense = defense;
        HP = hp;
        Critical = critical;
    }
}
