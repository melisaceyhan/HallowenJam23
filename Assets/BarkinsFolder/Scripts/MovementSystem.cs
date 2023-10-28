using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : MonoBehaviour
{
    public static MovementSystem Instance;
    public delegate void MovementSystemLeft();
    public event MovementSystemLeft movementSystemLeft;

    public delegate void MovementSystemRight();
    public event MovementSystemRight movementSystemRight;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            movementSystemRight();
        }

        else if (Input.GetKey(KeyCode.D))
        {
            movementSystemLeft();

        }
    }
}
