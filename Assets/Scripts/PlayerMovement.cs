using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Animator animator;
    private float speed = 3.0f; // prêdkoœæ bohatera
        void Start()
    {
      
    }

        void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0.0f);

        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));  // wyrzucenie danych do animatora
        
        transform.position = transform.position + movement * Time.deltaTime * speed;
    }
}
