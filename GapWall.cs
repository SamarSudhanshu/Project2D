using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GapWall : MonoBehaviour
{
    [SerializeField] float delayOnGapWall = 1f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (true)
        {
            Invoke("ReloadOnGapWall", delayOnGapWall);
        }
    }

    void ReloadOnGapWall()
    {
        SceneManager.LoadScene(0);
    }
}
