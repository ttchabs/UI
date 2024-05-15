using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
   public static InventoryManager Instance;
   public List<Item> Items = new List<Item>();

   private void Awake()
   {
       Instance = this;
   }

   public void Add(Item item)
   {
       Items.Add(item);
   }

   public void Remove(Item item)
   {
       Items.Remove(item);
   }
}
