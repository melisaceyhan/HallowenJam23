using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject chest;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            chest.GetComponent<BoxCollider2D>().enabled = false; 
            this.gameObject.SetActive(false);   

        }
    }
}
