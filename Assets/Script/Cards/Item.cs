using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private CardData cardData;
    public CardData CardData { get { return cardData; } }
}
