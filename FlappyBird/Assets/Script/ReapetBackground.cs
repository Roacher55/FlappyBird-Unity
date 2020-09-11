using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReapetBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;

    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x *2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHorizontalLength)
        {
            
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Debug.Log("dziala");
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2, 0);
        transform.position = (Vector2)transform.position + groundOffSet;
    }
}
