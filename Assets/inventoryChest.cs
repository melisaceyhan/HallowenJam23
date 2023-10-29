using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryChest : MonoBehaviour
{
    public Sprite openChest;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") { 
            
            if (collision.gameObject.GetComponent<playerInventorySistem>().hasKey == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite=openChest;    
            }
            
           
            
        }
    }
}
