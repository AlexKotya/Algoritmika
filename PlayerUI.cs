using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;

    // Update is called once per frame
    void Update()
    {
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;
        coinsCounterText.text = player.coins.ToString();
    }
}
