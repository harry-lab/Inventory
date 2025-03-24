using UnityEngine;

[System.Serializable]
public class Item
{
    public string Name;
    public Sprite Icon;
    public int Count;

    public Item(string name, Sprite icon, int count)
    {
        Name = name;
        Icon = icon;
        Count = count;
    }
}
