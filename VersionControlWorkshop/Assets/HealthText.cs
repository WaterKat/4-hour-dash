using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthText : MonoBehaviour
{
    public PlayerHealth playerHealth;

    public TextMeshProUGUI textMesh;
    float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    public void Update()
    {
        textMesh.text = "Health : " + playerHealth.Health + "/100";
    }

}
