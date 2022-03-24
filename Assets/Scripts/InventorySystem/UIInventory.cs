using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{

    [SerializeField] Sprite yellowBall;
    [SerializeField] Sprite greenBall;

    
}
    /*private Inventory inventory;
    private Transform container;
    private Transform inventorySlot;

    private void Awake(){
        container = transform.Find("container");
        inventorySlot = container.Find("inventorySlot");
        
    }

    public void SetInventory(Inventory inventory){
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems(){
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 30f;

        /*foreach (Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(inventorySlot, container).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            Image image = itemSlotRectTransform.Find("image").GetComponent<Material>();
            image.sprite = item.GetSprite();
            x++;
            if (x > 4) {
                x = 0;
                y++;
            }
        }
    }
}*/

