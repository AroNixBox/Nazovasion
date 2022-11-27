using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    Transform target;
    public float speed;
    PlayerController player;
    public int enemyHP = 100;
    //public Animator animator;
    public Slider enemyHealthBar;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        player = FindObjectOfType<PlayerController>();
        Physics2D.IgnoreCollision(target.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        enemyHealthBar.value = enemyHP;
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    public void TakeDamage(int damageAmount)
    {
        enemyHP -= damageAmount;
        enemyHealthBar.value = enemyHP;
        if (enemyHP > 0)
        {
            //Add get hit animation here!!!
            //animator.SetTrigger("damage");
        }
        else
        {
            //Add death animation here
            //animator.SetTrigger("death");
            GetComponent<BoxCollider2D>().enabled = false;
            this.enabled = false;
            //remove this line, if we want the corpses of the zombies to stack on the ground...
            Object.Destroy(gameObject, 3.0f);
        }
    }
}
