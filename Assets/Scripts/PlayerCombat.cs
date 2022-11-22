using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint; //centralny punkt z którego wychodziu atak
    public float attackRange = 0.5f; // promieñ ataku
    public LayerMask enemyLayers;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack(); 
        }
    }
    void Attack()
    {
        animator.SetTrigger("Attack"); // wywo³ywanie animacji ataku

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log(enemy.name + "zostal dupniety");
        }
    }
}
