using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Image[] InventorySlots;
    public Sprite[] InventorySprites;
    
    private int fillIndex = 0;
    public void FixedUpdate()
    {
        for (int i = 0; i < InventorySystem.inventory.Count; i++)
        {
            InventorySlots[i].sprite = InventorySprites[(int) InventorySystem.inventory[i]];
        }
    }
}