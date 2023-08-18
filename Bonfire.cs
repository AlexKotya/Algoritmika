using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    public float lifeTime = 15;
    public float heatPower = 0.1f;

    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerStay(Collider other)
    {
            Temperature temperature = other.GetComponent<Temperature>();

        if (temperature)
        {

            if (temperature.temperatureCurrent < temperature.temperatureNormal)
            {
                temperature.temperatureCurrent += heatPower * Time.deltaTime;
            }
        }
    }


}