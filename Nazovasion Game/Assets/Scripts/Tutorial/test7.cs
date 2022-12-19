using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test7 : MonoBehaviour
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
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
