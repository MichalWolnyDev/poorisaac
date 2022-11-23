using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Animator animator;
    public Rigidbody2D rigidbody;
    public float moveSpeed = 3.0f; // pr�dko�� bohatera


    // start is called before the first frame update
        void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>(); // it finds rigidbody of player and init it to rigidbody variable, easiest way to use rigidbody variable in the future
    }

    // update is called once per frame
        void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0.0f);

        if(horizontal != 0){
        animator.SetFloat("moveSpeed", horizontal);  // wyrzucenie danych do animatora

        } else if(vertical != 0){
        animator.SetFloat("moveSpeed", vertical); 

        } else {
            animator.SetFloat("moveSpeed", 0.0f);  
        }



        
        transform.position = transform.position + movement * Time.deltaTime * moveSpeed;
    }
}
