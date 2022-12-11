using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Timers;
using System.Diagnostics;
using System;
using System.Threading;
using UnityEngine.SceneManagement;
public class CountUpTimer : MonoBehaviour
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
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        
        if (hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
        {
            //caps off our current time
            currentTime = timerLimit;
            timerText.color = Color.red;
            enabled = false;
            Invoke("endScene", 3);
        }
        setTimerText();
        

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
