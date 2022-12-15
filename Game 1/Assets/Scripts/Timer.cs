using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI score;
    public float timer = 0;
    public float timerRounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        timerRounded = Mathf.Round(timer * 10.0f) * 0.1f;
        score.text = timerRounded.ToString();
    }
}
