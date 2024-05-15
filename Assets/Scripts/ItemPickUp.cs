using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1 : MonoBehaviour
{
   public Item Item;
   
   void Pickup()
   {
      InventoryManager.Instance.Add(Item);
      Destroy(gameObject);
   }

   private void OnMouseDown()
   {
       Pickup(); 
   }
}
