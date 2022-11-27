using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Start()
    {
        Destroy();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
            collision.GetComponent<EnemyController>().TakeDamage(25);
        }
    }
    
    private void Destroy()
    {
        Object.Destroy(gameObject, 1.0f);
    }

}
