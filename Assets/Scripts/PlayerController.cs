﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;

    float horizontal;
    float vertical;
    public float speed = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime);
    }
}