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
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && attackSpeed <= canAttack)
        {
            Debug.Log("itsWorking!");
            other.gameObject.GetComponent<PlayerHealth>().UpdateHealth(-attackDamage);
            StartCoroutine("DisableScript");
            canAttack = 0f;
        }
        else
        {
            canAttack += Time.deltaTime;
        }
    }
    IEnumerator DisableScript ()
    {
        refScript.enabled = false;
        yield return new WaitForSeconds(1f);
        refScript.enabled = true;
    }
}
