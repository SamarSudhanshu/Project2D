using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishFlag : MonoBehaviour
{
    [SerializeField] float delayTimeOnFinish = 1f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(true)
        {
            Debug.Log("game finished");
            GetComponent<AudioSource>().Play();
            Invoke("ReloadSceneOnFinish", delayTimeOnFinish);
        }
    }

    void ReloadSceneOnFinish()
    {
        SceneManager.LoadScene(0);
    }
}
