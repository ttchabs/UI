using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackPackSlotInfo : MonoBehaviour
{public int ItemID;
    public Text Pricetxt;
    public Text Quantitytxt;
    public GameObject ShopManager;
    
    // Update is called once per frame
    void Update()
    {
        Pricetxt.text = "Price: $" + ShopManager.GetComponent<ShopManagerScript>().shopItems[2,ItemID].ToString();
        Quantitytxt.text =  ShopManager.GetComponent<ShopManagerScript>().shopItems[3,ItemID].ToString();
    }
}
