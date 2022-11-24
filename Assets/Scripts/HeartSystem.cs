using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;
    private bool dead;

    private void Start(){
        life = hearts.Length;
    }

    // Update is called once per frame
    void Update()
    {
        // if(life < 1){
        //     Destroy(hearts[0].gameObject);
        // } else if (life < 2){
        //      Destroy(hearts[1].gameObject);
        // } else if (life < 3){
        //      Destroy(hearts[2].gameObject);
        // }

        if(dead == true){
            // set dead
            Debug.Log("we are dead xd");
        }
    }

    public void TakeDamage(int damage){

        if(life >= 1){
            life -= damage;
            Destroy(hearts[life].gameObject);

            if(life < 1){
                dead = true;
            }
        }
    }
}
