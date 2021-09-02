using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InputReader inputReader;

    public Vector2 previousMove;
    public Vector3 inputVector;
    public Vector3 moveVector;

    private void Awake()
    {
        inputVector = new Vector3();
    }

    private void OnEnable()
    {
        inputReader.moveEvent += ApplayPreviousMove;
    }

    private void OnDisable()
    {
        inputReader.moveEvent -= ApplayPreviousMove;
    }

    private void ApplayPreviousMove(Vector2 input)
    {
        previousMove = input;
    }

    // Update is called once per frame
    void Update()
    {
        inputVector = new Vector3(previousMove.x, 0, previousMove.y);
    }
}
