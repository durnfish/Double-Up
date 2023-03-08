using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<ItemIndex> items;

    [SerializeField] Item item;
    [SerializeField] private int draw;
    public int Draw// ī�� ��ο� 
    {
        get { return draw; }
        set { Draw = value; }
    }

    public Cell[] cells;

    private void Awake()
    {
        items = new List<ItemIndex>();

        cells = this.transform.GetComponentsInChildren<Cell>();
        FreshCell();

    }

    private void Start()
    {
        StartCoroutine(Twinkle(item));
    }
    private void FreshCell()
    {
        for (int i = 0; i < cells.Length; i++)
        {
            cells[i].item = null;
        }
        for (int i = 0; i < items.Count && i < cells.Length; i++)
        {
            int index = items[i].Index;
            cells[index].item = items[i].Item;
        }
        
    }

    public void AddItem(Item _item)
    {
        int randNum = Random.Range(1, cells.Length ); // 1���� �� ũ�� ������ ������ ���� �ϳ�
        

        if (cells[randNum].item != null) AddItem(_item); // �̹� �ڸ��� �� �ִٸ� �ٽ� �ڸ� ���

        if (items.Count < cells.Length)
        {
            Debug.Log(randNum);

            items.Add(new ItemIndex(_item,randNum));
            FreshCell();
        }
        else
        {
            print("������ ���� �� �ֽ��ϴ�.");
        }
    }

    IEnumerator Twinkle(Item item)
    {
        while (true)
        {
            AddItem(item);

            yield return new WaitForSeconds(2);


            items.RemoveAt(0);
        }
    }
}
