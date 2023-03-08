using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private CardData cardData;
    public CardData CardData { get { return cardData; } }

    private int durability
    {
        get { return durability; }
        set { durability = cardData.Durability; }
    }

    private void DurabilityDecrease() // 1���� ������ ������ ����
    {
        durability--;

        if (durability == 0) // 0�� �Ǹ� �ı�
        {
            Destroy(this.gameObject);
        }
    }

    public void DurabilityIncrease(int value)
    {
        durability += value;
    }
}
