using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

[SerializeField]
private int damage = 1;
[SerializeField]
private float speed = 1.5f;

[SerializeField]
private EnemyData data;

private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Rat();
    }

    private void Rat(){
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Player")){
            if(collider.GetComponent<HeartSystem>() != null){
                collider.GetComponent<HeartSystem>().TakeDamage(damage);
                this.GetComponent<HeartSystem>().TakeDamage(10000);
            }
        }
    }
}


