using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test5 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            StartCoroutine(DestroyPlattform1());
        }

    }
    IEnumerator DestroyPlattform1()
    {
        yield return new WaitForSeconds(13);
        Destroy(gameObject);
    }
}
