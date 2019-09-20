using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public Collider2D collider;

    public float JumpVelocity = 10;
    public float Spin = 10;

    bool CheckIfGrounded()
    {
        bool grounded = false;

        RaycastHit2D[] raycastHit2Ds = new RaycastHit2D[3];
        if (collider.Raycast(Vector2.down, raycastHit2Ds, .5f)>0)
        {
            grounded = true;
        }

        return grounded;
    }
    void Update()
    {
        bool inputValue = Input.GetKeyDown("space");

        if ((inputValue)&&(CheckIfGrounded()))
        {
            Vector3 velocity = rigidBody.velocity;
            velocity.y = JumpVelocity;
            rigidBody.velocity = velocity;

            rigidBody.angularVelocity = Spin;
        }
    }
}
