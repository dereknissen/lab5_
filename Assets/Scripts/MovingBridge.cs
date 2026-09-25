using System;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class MovingBridge : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool movingEnabled = true;
    public int distance = 5;
    public float speed = 5f;
    private float startingX;
    void Start()
    {
        startingX = transform.position.x;
    }

    // Update is called once per frame

    private bool movingRight = true;
    void Update()
    {
        if (movingRight)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
            if (transform.position.x >= distance + startingX)
            {
                movingRight = false;

            }
        } else
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0, Space.World);
            if (transform.position.x <= startingX)
            {
                movingRight = true;

            }
        }
    }
}
