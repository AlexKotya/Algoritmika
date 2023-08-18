using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        CoinsCounter player = other.GetComponent<CoinsCounter>();

        //Количество монеток обновляется
        player.CollectCoins();

        //Монетка, которую собрали, уничтожается
        Destroy(gameObject);
    }

}
