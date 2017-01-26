using UnityEngine;
using System.Collections;

public class aiAttack : MonoBehaviour {

    public Animator anim;
    public bool isAttacking = false;
    public aiStats aiStats;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="Player")
        {
            anim.SetBool("Attack", true);
            isAttacking = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            anim.SetBool("Attack", false);
            isAttacking = false;
        }

    }

    void Update()
    {
        if (isAttacking==true)
        {
            PlayerStats.pHealth -= aiStats.aiDamage * Time.deltaTime * aiStats.aiAttackSpeed;
        }
    }

}
