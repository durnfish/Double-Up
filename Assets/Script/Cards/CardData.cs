using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Card", menuName = "Scriptable Object/Card", order = int.MaxValue)]
public class CardData : ScriptableObject
{
    [SerializeField] private string cardName;
    [SerializeField] private int damage;
    [SerializeField] private int defense;
    [SerializeField] private int durability;
    [SerializeField] private int grade;
    [SerializeField] private Sprite sprite;

    public string CardName { get { return cardName; } }
    public int Damage { get { return damage; } }
    public int Defense { get { return defense; } }
    public int Durability { get { return durability; } }
    public int Grade { get { return grade; } }
    public Sprite Sprite { get { return sprite; } }
}
