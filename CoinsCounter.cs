using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    public int coins;
    public AudioClip collectSound;

    public void CollectCoins()
    {
        coins++;

        //audioSource.PlayOneShot(collectSound);

        print("Собранные монетки: " + coins);
    }
}
