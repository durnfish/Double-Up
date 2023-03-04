using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemIndex
{
    private Item item;
    private int index;

    public Item Item { 
        get { return item; } 
        set { item = value; } 
    }
    public int Index
    {
        get { return index; }
        set { index = value; }
    }

    public ItemIndex(Item item,int index)
    {
        this.item = item;
        this.index = index;
    }
}
