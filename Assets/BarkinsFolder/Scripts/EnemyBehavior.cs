using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyBehavior : MonoBehaviour
{
    public int enemySpeed = 10;
    private bool isEating = false;
    private Animator _animator;
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
    }

    void EnemyGoesLeft()
    {
        transform.Rotate(new Vector3(-1, 1, 1) * Time.deltaTime * enemySpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Eatable")
        {
            StartCoroutine(EatingEatables());
            if (collision.gameObject.tag == "Player")
            {
                StartCoroutine(EatingPlayer());
            }
        }

        IEnumerator EatingEatables()
        {
            isEating = true;
            _animator.SetBool(animatonName, true);
            yield return new WaitForSeconds(animationTime);
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
}
