﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Right : MonoBehaviour
{
    public float speed;

    Rigidbody2D rig;

    void Start()
    {

        rig = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {

        float move = Input.GetAxis("Vertical_Direita");
        rig.velocity = new Vector2(0f,move * speed);

    }
}
