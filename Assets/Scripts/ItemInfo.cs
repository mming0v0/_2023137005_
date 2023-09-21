using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    public int slotld;      //슬롯 번호
    public int itemld;      //아이템 번호

    public void InitDummy(int slotld, int itemld)
    {
        this.slotld = slotld;
        this.itemld = itemld;
    }
}