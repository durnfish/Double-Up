using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<ItemIndex> items;

    [SerializeField] Item item;
    [SerializeField] private int draw;
    public int Draw// 카드 드로우 
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
        int randNum = Random.Range(1, cells.Length ); // 1부터 셀 크기 사이의 랜덤한 숫자 하나
        

        if (cells[randNum].item != null) AddItem(_item); // 이미 자리가 차 있다면 다시 자리 잡기

        if (items.Count < cells.Length)
        {
            Debug.Log(randNum);

            items.Add(new ItemIndex(_item,randNum));
            FreshCell();
        }
        else
        {
            print("슬롯이 가득 차 있습니다.");
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
