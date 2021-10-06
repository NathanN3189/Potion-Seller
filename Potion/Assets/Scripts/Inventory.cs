using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> playerItems = new List<Item>();
    [SerializeField]
    private UIInventory inventoryUI;
    ItemDataBase itemDataBase;

    private void Awake()
    {
        itemDataBase = FindObjectOfType<ItemDataBase>();
        
    }

    private void Start()
    {
        GiveItem(1);
        GiveItem(2);
        GiveItem(3);

        GiveItem(2);


        GiveItem(3);
        GiveItem(3);
        GiveItem(1);
    }

    public void GiveItem(int id)
    {
        Item itemToAdd = itemDataBase.GetItem(id);
        inventoryUI.AddItemToUI(itemToAdd);
        playerItems.Add(itemToAdd);
    }

    public void GiveItem(string itemName)
    {
        Item itemToAdd = itemDataBase.GetItem(itemName);
        inventoryUI.AddItemToUI(itemToAdd);
        playerItems.Add(itemToAdd);
    }

    public Item CheckForItem(int id)
    {
        return playerItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);

        if(itemToRemove != null)
        {
            playerItems.Remove(itemToRemove);
        }
    }
}
