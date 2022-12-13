using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using System.Diagnostics;
using System;
using System.Threading;
using UnityEngine.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Component")]
    public float currentTime;
    public bool countDown;
    public bool hasLimit;
    public float timerLimit;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (KeyPad.isActive)
        {
            currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
            if (hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
            {
                //caps off our current time
                currentTime = timerLimit;
                timerText.color = Color.red;
                enabled = false;
                Invoke("endScene", 3);
            }
        }
        setTimerText();
        if (KeyPad.pressCounter >= 2)
        {

            KeyPad.audiosrc.Play();
            Invoke("endScene", 3);
            KeyPad.pressCounter = 0;
            KeyPad.isActive = false;
        }

    }
    private void setTimerText()
    {
        timerText.text = currentTime.ToString("0.00");
    }

    private void endScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
