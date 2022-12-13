using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

[SerializeField]
private EnemyData data;

private GameObject player;

private Vector2 target;
private Vector2 position;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform.position;
        position = gameObject.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyPosition();
    }

    private void EnemyPosition(){
        float step = data.speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }

    
    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Player")){
            if(collider.GetComponent<Health>() != null){
                collider.GetComponent<Health>().Damage(data.damage);
            }
        }
    }
}


