using System.Collections;
using System.Collections.Generic;

public class CountdownScript : UnityEngine.MonoBehaviour
{
    public UnityEngine.UI.Text Countdown; // Text component on interface

    private float startTime = 5.5f; // Start counting down from
    private float timeRemaining;    // Calculate time remaining
    private float endTime = 0.5f;   // Time to stop counting down at

	// Use this for initialization
	void Start()
    {
        timeRemaining = startTime;
        Countdown = Countdown.GetComponent<UnityEngine.UI.Text>();
	}
	
    // Countdown system that runs in the game loop
    // Using delta time, updating the text component on screen with time until start
    private void CountdownSystem()
    {
        if (timeRemaining > endTime)
        {
            timeRemaining -= UnityEngine.Time.deltaTime;
            Countdown.text = System.Math.Round(timeRemaining).ToString();
        }
        else
        {
            Countdown.text = "Go!";
        }
    }
	// Update is called once per frame
	void Update()
    {
        CountdownSystem();
	}
}
