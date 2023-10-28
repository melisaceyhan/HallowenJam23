using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyBehavior : MonoBehaviour
{
    public int enemySpeed = 10;
    private bool isEating = false;
    public Animator _animator;
    public string animatonName;
    public int animationTime;
    public GameObject deadAnimObject;
    void Start()
    {
        isEating = false;
        _animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (!isEating)
        {
            EnemyGoesLeft();
        }

        if (Input.GetKey(KeyCode.A))
        {
            enemySpeed = 8;
        }
        else
        {
            enemySpeed = 25;
        }
    }

    void EnemyGoesLeft()
    {
        transform.Rotate(new Vector3(0, 0 , -1) * Time.deltaTime * enemySpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Eatable")
        {
            StartCoroutine(EatingEatables(collision));
        }
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(EatingPlayer());
        }
    }

    IEnumerator EatingEatables(Collider2D colliision)
    {
        isEating = true;
        _animator.SetBool(animatonName, true);
        yield return new WaitForSeconds(1f);
        Destroy(colliision.gameObject);
        yield return new WaitForSeconds(animationTime);
        _animator.SetBool(animationTime, false);
        isEating = false;
    }

    IEnumerator EatingPlayer()
    {
        isEating = true;
        _animator.SetBool(animationTime, true);
        yield return new WaitForSeconds(animationTime);
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(y + 1);

    }
}
