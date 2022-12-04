using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;

    private int hearthNumber = 5;
    private int MAX_HEALTH = 100;
    public GameObject[] hearts;
    public Animator animator;

   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Damage(10);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            // Heal(10);
        }
    }

    public void SetHealth(int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }

    private IEnumerator VisualIndicator(Color color) // u�ywany po to by po uderzeniu wr�g zosta� pod�wietlony na czerwono
    {
        GetComponent<SpriteRenderer>().color = color;
        yield return new WaitForSeconds(0.15f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    public void Damage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        this.health -= amount;
        StartCoroutine(VisualIndicator(Color.red));


        if(gameObject.tag == "Player") { 
            if(this.health < 100 && this.health >= 80 && this.hearthNumber == 5){
                 Destroy(hearts[4].gameObject);
                 this.hearthNumber -= 1;
                
            } else if(this.health < 80 && this.health >= 60 && this.hearthNumber == 4) {
                 Destroy(hearts[3].gameObject);
                  this.hearthNumber -= 1;
            } else if(this.health < 60 && this.health >= 40 && this.hearthNumber == 3) {
                Destroy(hearts[2].gameObject);
                 this.hearthNumber -= 1;
            } else if(this.health < 40 && this.health >= 20 && this.hearthNumber == 2) {
                Destroy(hearts[1].gameObject);
                 this.hearthNumber -= 1;
            } else if(this.health <= 0 && this.hearthNumber == 1) {
                Destroy(hearts[0].gameObject);
                 this.hearthNumber -= 1;
            }
        }
            
        

        if (health <= 0)
        {
            Die();
        }
    }


    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;

        if (wouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }
        else
        {
            this.health += amount;
        }
    }

    private void Die()
    {
        Debug.Log("I am Dead!");
        if(gameObject.tag == "Player"){
                animator.SetTrigger("Dead");
        SoundManagerScript.PlaySound("playerDeath"); // odtwarza d�wi�k �mierci gracza
        }
    
        // Destroy(gameObject);
    }
}