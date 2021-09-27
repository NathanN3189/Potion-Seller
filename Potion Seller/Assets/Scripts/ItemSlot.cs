using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    
    public Image Image;

    public Item item;

    private void OnValidate()
    {
        if (Image == null)

            Image = GetComponent<Image>();
                
    }


}
