using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    private Item _item;
    private SpriteRenderer spriteRenderer;

    [SerializeField] private Sprite nullSprite;

    public Item item
    {
        get { return _item; }
        set
        {
            _item = value;
            if (_item != null)
            {
                Instantiate(_item, transform);
            }
            else
            {
                spriteRenderer = GetComponent<SpriteRenderer>();

                spriteRenderer.sprite = nullSprite;
                spriteRenderer.color = new Color(1, 1, 1, 0.3f);
            }
        }
    }
}
