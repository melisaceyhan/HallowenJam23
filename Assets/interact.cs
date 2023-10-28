using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public Transform detectionPoint;

    private const float detectionRadius = 10f;

    public LayerMask detectionLayer;
    public EtkilesimliNesne x;

    void Update()
    {
        if(DetectObject())
        {
            if(InteractInput())
            {
                Debug.Log("INERACT");
                
            }
        }

    }

    bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    bool DetectObject()
    {
        
        return Physics2D.OverlapCircle(detectionPoint.position,detectionRadius,detectionLayer);
    
    }


}