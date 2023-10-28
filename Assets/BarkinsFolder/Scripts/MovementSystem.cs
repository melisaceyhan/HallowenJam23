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

    public bool isMissionDone = false;

    private void Awake()
    {
        Instance = this;
        //Bu true olduðu zaman canavar ortaya çýkacak, o yüzden
        //oyuncu görevi tamamlayana kadar false'da kalacak.
        isMissionDone = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
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
