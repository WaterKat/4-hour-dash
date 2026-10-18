using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public GameObject gameoverObject;
    int _health = 100;
    public int Health
    {
        get { return _health; }
        set { _health = value; if (_health <= 0) { _health = 0; DieAnimation(); } }
    }
    IEnumerator ReloadSceneAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void DieAnimation()
    {
        gameoverObject.SetActive(true);
        GetComponent<Rigidbody2D>().isKinematic = true;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Animator>().SetTrigger("Die");
        StartCoroutine(ReloadSceneAfterDelay(1));

    }
    public void TakeDamageAnimation()
    {
        GetComponent<Animator>().SetTrigger("TakeDamage");
    }
}
