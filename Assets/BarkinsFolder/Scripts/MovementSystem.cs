using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementSystem : MonoBehaviour
{
    public static MovementSystem Instance;
    public delegate void MovementSystemLeft();
    public event MovementSystemLeft movementSystemLeft;

    public delegate void MovementSystemRight();
    public event MovementSystemRight movementSystemRight;

    public bool isMissionDone = false;

    private Animator animator;

    private Vector3 respawnPoint;

    private void Awake()
    {
        Instance = this;
        //Bu true olduðu zaman canavar ortaya çýkacak, o yüzden
        //oyuncu görevi tamamlayana kadar false'da kalacak.
        isMissionDone = false;

        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementSystemRight();
            animator.SetBool("Moving", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            movementSystemLeft();
            animator.SetBool("Moving", true);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Moving", false);
            //transform.localScale = new Vector3(-1 * transform.localScale.x, 1, 1);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*
        if (collision.tag == "FallDetector")
        {
            transform.position = respawnPoint;
        }
        else if (collision.tag == "Checkpoint")
        {
            respawnPoint = transform.position;
        }*/
        if (collision.tag == "NextLevel")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            // Or you can use SceneManager.LoadScene(1); to load a specific scene instead

            respawnPoint = transform.position;
        }
        else if (collision.tag == "PreviousLevel")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            respawnPoint = transform.position;
        }
    }
}
