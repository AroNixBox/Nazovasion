using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    EnemyAttack enemyAttack;
    RangeEnemyAttack rangeEnemyAttack;
    PlayerController player;
    public int enemyHP = 100;
    //public Animator animator;
    public Slider enemyHealthBar;

    GameObject target;
    void Start()
    {
        //this line ignores collision with enemy, but when I enable, attack system doesnt work... target = GameObject.FindGameObjectWithTag("Player").transform;
        //this also Physics2D.IgnoreCollision(target.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        player = FindObjectOfType<PlayerController>();
        enemyHealthBar.value = enemyHP;
        enemyAttack = GetComponent<EnemyAttack>();
        rangeEnemyAttack = GetComponent<RangeEnemyAttack>();
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
            ScoreManager.instance.AddPoint();
            //Add death animation here
            //animator.SetTrigger("death");
            GetComponent<BoxCollider2D>().enabled = false;
            //remove this line, if we want the corpses of the zombies to stack on the ground...
            Object.Destroy(gameObject, 3.0f);
            if(tag == "Enemy")
            {
                enemyAttack.enabled = false;
            }
            if (tag == "RangedEnemy")
            {
                rangeEnemyAttack.enabled = false;
            }
        }
    }
}