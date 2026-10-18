using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public int Score;
    public TextMeshProUGUI textMesh;
    float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    public void Update()
    {
        textMesh.text = "Score : " + Mathf.Floor(Time.time - startTime);
    }

}
