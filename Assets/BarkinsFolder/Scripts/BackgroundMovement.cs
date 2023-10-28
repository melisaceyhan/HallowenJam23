using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] private int speedOfRotate;
    void Start()
    {
        MovementSystem.Instance.movementSystemLeft += TurningLeft;
        MovementSystem.Instance.movementSystemRight += TurningRight;
    }
    void TurningLeft()
    {
        transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * speedOfRotate);
    }

    void TurningRight()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * speedOfRotate);
    }
}
