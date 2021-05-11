using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [SerializeField] bool isCountdown;
    [SerializeField] float maxTime;
    [SerializeField] float currentTime;

    [SerializeField] Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        if(isCountdown == true)
        {
            currentTime = maxTime;
        }
        else
        {
            currentTime = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isCountdown == true)
        {
            currentTime = currentTime - 1 * Time.deltaTime;
            timerText.text = currentTime.ToString("F2");
        }
        else
        {
            currentTime = currentTime + 1 * Time.deltaTime;
            timerText.text = currentTime.ToString("F2");
        }
    }
}
