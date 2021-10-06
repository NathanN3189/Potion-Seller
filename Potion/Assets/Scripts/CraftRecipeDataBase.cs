using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class CraftRecipeDataBase : MonoBehaviour
{
    public List<CraftRecipe> recipes;

    private ItemDataBase itemDataBase;


    private void Awake()
    {
        itemDataBase = GetComponent<ItemDataBase>();
        BuildCraftRecipeDataBase();
    }

    public Item CheckRecipe(int[] recipe)
    {
        foreach (CraftRecipe craftRecipe in recipes)
        {
            if (craftRecipe.requiredItems.OrderBy(i => i).SequenceEqual(recipe.OrderBy(i => i)))
            {
                return itemDataBase.GetItem(craftRecipe.itemToCraft);
            }
        }
        return null;
    }

    void BuildCraftRecipeDataBase()
    {
        recipes = new List<CraftRecipe>()
        {
            new CraftRecipe(1, new int[]{

                0, 0, 0,
                0, 2, 0,
                0, 0, 0
            }),

             new CraftRecipe(2, new int[]{

                3, 0, 0,
                0, 3, 0,
                0, 0, 3
            }),

              new CraftRecipe(3, new int[]{

                1, 0, 2,
                0, 2, 0,
                0, 0, 0
            })

        };
    }


}
