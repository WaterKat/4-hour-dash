using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public float XOffset;

    private void LateUpdate()
    {
        Vector3 position = Camera.main.transform.position;
        position.x = Player.transform.position.x + XOffset;
        Camera.main.transform.position = position;
    }
}
