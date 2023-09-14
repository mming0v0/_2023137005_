using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    public int slotld;
    public int itemId;

    public void InitDummy(int slotld, int itemId)
    {
        this.slotld = slotld;
        this.itemId = itemId;
    }
}
