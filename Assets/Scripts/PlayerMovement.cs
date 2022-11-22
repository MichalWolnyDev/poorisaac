using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Animator animator;
    public Rigidbody2D rigidbody;
    private float speed = 3.0f; // pr�dko�� bohatera


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

        animator.SetFloat("Horizontal", horizontal);  // wyrzucenie danych do animatora
        
        transform.position = transform.position + movement * Time.deltaTime * speed;
    }
}
