using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float crashDelayTime = 1f;
    [SerializeField] ParticleSystem crashEffect;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            crashEffect.Play();
            GetComponent<AudioSource>().Play();
            Debug.Log("killed");
            Invoke("ReloadSceneOnCrash", crashDelayTime);
        }
    }

    void ReloadSceneOnCrash()
    {
        SceneManager.LoadScene(0);
    }
}
