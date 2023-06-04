using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] float destroyDelay = 1f;
    int numberOfCoins = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coins")
        {
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject, destroyDelay);
            numberOfCoins++;
        }
        Debug.Log(numberOfCoins);
    }
}
