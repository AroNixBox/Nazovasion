using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test7 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        StartCoroutine(DestroyPlattform1());

    }
    IEnumerator DestroyPlattform1()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
