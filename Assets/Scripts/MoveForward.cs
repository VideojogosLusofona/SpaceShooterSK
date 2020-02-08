using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class MoveForward : MonoBehaviour
{
    public bool     useObjectDirection;
    [HideIf("useObjectDirection")]
    public Vector3  moveVector = Vector3.one;
    public float    speed = 400;

    float   timer = 0.0f;
    Vector3 startPos;

    void Start()
    {
        if (useObjectDirection) moveVector = transform.up;

        moveVector.Normalize();

        startPos = transform.position;
    }

    private void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;

        transform.position = startPos + moveVector * speed * timer;
    }

    void Update()
    {
        
    }
}
