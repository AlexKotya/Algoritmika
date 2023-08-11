using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public int minutes;
    public float seconds;

    void Update()
    {
        seconds -= Time.deltaTime;

        if (seconds < 0 )
        {
            if ( minutes > 0 )
            {
                minutes--;
                seconds += 60;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }

        timerText.text = minutes + ":" + (int)seconds;
    }
}
