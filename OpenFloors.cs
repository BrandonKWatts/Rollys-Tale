﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenFloors : MonoBehaviour {

    private Vector2 startPosition;
    private Vector2 newPosition;

    [SerializeField] private int speed = 3;
    [SerializeField] private float maxDistance = 1;

    void Start()
    {
        startPosition = transform.position;
        newPosition = transform.position;
    }

    void Update()
    {
        newPosition.x = startPosition.x + (maxDistance * Mathf.Sin(Time.time * speed));
        transform.position = newPosition;
    }
}

