using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpBonus = 5f;

    // ����� ����� ������� � ���� �������� jumpStrength ���������� �� jumpBonus
    void OnTriggerEnter( Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpBonus;
    }

    // Update is called once per frame
    void OnTriggerExit( Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpBonus;
    }
}
