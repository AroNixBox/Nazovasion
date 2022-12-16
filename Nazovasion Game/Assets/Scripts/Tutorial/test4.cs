using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        StartCoroutine(DestroyPlattform1());

    }
    IEnumerator DestroyPlattform1()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
