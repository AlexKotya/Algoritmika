using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;

    //Fps is being faster when its entering collider
    void OnTriggerEnter( Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
        
    }

    //And when it goes from trigger zone the speed is default
    void OnTriggerExit( Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
