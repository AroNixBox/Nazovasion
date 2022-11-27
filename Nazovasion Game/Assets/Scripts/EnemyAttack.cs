using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    EnemyController refScript;

    [SerializeField] private float attackDamage = 10f;
    [SerializeField] private float attackSpeed = 1f;
    private float canAttack;

    private void Start()
    {
        refScript = GetComponent<EnemyController>();
    }
    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (attackSpeed <= canAttack)
            {
                Debug.Log("itsWorking!");
                col.gameObject.GetComponent<PlayerHealth>().UpdateHealth(-attackDamage);
                canAttack = 0f;
                StartCoroutine("DisableScript");
            }
            else
            {
                canAttack += Time.deltaTime;
            }
        }

    }
    IEnumerator DisableScript ()
    {
        refScript.enabled = false;
        yield return new WaitForSeconds(1f);
        refScript.enabled = true;
    }
}
