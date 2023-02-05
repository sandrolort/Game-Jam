using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InventorySystem
{
    public static List<items> inventory = new List<items>();
    public static bool checkForItem(items item)
    {
        return inventory.Contains(item);
    }
    public static bool tryRemovingItem(items item)
    {
        if (checkForItem(item))
        {
            inventory.Remove(item);
            return true;
        }
        else
        {
            return false;
        }
    }
}

public enum items
{
    key
}