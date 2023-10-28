using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction_Spawn : MonoBehaviour
{
    public GameObject cheese; // The cheese object attached to the tree
    private bool cheeseFalling = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !cheeseFalling)
        {
            StartCoroutine(DropCheese());
        }
    }

    private IEnumerator DropCheese()
    {
        cheeseFalling = true;

        // Deactivate the cheese object
        cheese.SetActive(false);

        yield return new WaitForSeconds(0.5f); // Adjust the delay as needed

        // Reactivate the cheese object
        cheese.SetActive(true);

        cheeseFalling = false;
    }
}

