using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovementScript : MonoBehaviour
{
    private void Update()
    {
        if ((Input.GetKey(KeyCode.A))||(Input.GetKey(KeyCode.LeftArrow)))
        {
            gameObject.transform.Rotate(0f,0f,10f*Time.deltaTime*10f);
        }
        else if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            gameObject.transform.Rotate(0f, 0f, -10f * Time.deltaTime * 10f);
        }
    }
}
