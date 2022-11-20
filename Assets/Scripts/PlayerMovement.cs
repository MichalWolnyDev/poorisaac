using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _moveSpeed;
    

         private void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * _moveSpeed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * _moveSpeed;

        _rigidbody.MovePosition(transform.position + new Vector3(moveX, moveY, 0));
    }
}
