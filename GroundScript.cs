using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    public float upSpeed = 2.5f;
    private Rigidbody2D groundRigid;
    private float xStart;
    
    void Start()
    {
        groundRigid = GetComponent<Rigidbody2D>();
        xStart = groundRigid.position.x;
    }

    void Update()
    {
        groundRigid.velocity = new Vector2(0, upSpeed);
        Respawn();
    }

    void Respawn()
    {
        if(transform.position.y > 6)
        {
            float xPos = Random.Range(xStart - 2f, xStart + 2f);
            float yPos = Random.Range(-8.0f, -5.0f);
            transform.position = new Vector2(xPos, yPos);
        }
    }
}
