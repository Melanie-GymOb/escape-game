using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=2WnAOV7nHW0


public class Inventory : MonoBehaviour
{
    private List<Item> itemList;

    public void AddItem(Item item){
        itemList.Add(item);
    }

    public List<Item> GetItemList(){
        return itemList;
    }

}


