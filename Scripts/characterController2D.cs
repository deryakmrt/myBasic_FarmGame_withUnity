using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

[RequireComponent(typeof(Rigidbody2D))]

public class characterController2D : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    private Rigidbody2D _rigidbody2d;
    private Animator _animator;
    Vector2 motionVector; // ++++
    public Vector2 lastMotionVector; //++++++++
    public bool moving;

    private void Awake()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>(); //cashing
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        motionVector = new Vector2(horizontal, vertical);

        _animator.SetFloat("horizontal", horizontal);
        _animator.SetFloat("vertical", vertical);

        moving = horizontal != 0 || vertical != 0;
        _animator.SetBool("moving", moving);

        if (horizontal != 0 || vertical != 0)
        {
            lastMotionVector = new Vector2(horizontal, vertical).normalized;

            _animator.SetFloat("lastHorizontal", horizontal);
            _animator.SetFloat("lastVertical", vertical);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _rigidbody2d.velocity = motionVector * speed;
    }
}