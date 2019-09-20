using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float ConstantSpeed = 10;
    private void FixedUpdate()
    {
        Vector3 velocity = rigidBody.velocity;
        velocity.x = ConstantSpeed;
        rigidBody.velocity = velocity;
    }
}
