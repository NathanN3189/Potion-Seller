using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSlots : MonoBehaviour
{
    public CraftRecipeDataBase recipeDatabase;

    private List<UIItem> uIItems = new List<UIItem>();

    public UIItem craftResultSlot;

    public void UpdateRecipe()
    {
        int[] itemTable = new int[uIItems.Count];

        for(int i = 0; i < uIItems.Count; i++)
        {
            if (uIItems[i].item != null)
            {
                itemTable[i] = uIItems[i].item.id;
            }
        }
        Item itemToCraft = recipeDatabase.CheckRecipe(itemTable);
        UpdateCraftingResultSlot(itemToCraft);
    }

    void UpdateCraftingResultSlot(Item itemToCraft)
    {
        craftResultSlot.UpdateItem(itemToCraft);
    }

    private void Start()
    {
        uIItems = GetComponent<SlotPanel>().uiItems;
        uIItems.ForEach(i => i.craftingSlot = true);

    }


}
