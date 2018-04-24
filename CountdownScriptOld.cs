using System.Collections;
using System.Collections.Generic;

public class CountdownScript : UnityEngine.MonoBehaviour
{
    public UnityEngine.UI.Text Countdown; // Text component on interface
    private bool hidden = false;          // Store hidden state
    private float startTime = 5.5f;       // Start counting down from
    private float timeRemaining = 0.0f;   // Calculate time remaining
    private float endTime = 0.5f;         // Time to stop counting down at
    private float timeToHide = -2.0f;     // Time to hide the countdown

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
        timeRemaining -= UnityEngine.Time.deltaTime;

        if (timeRemaining > endTime)
        {
            Countdown.text = System.Math.Round(timeRemaining).ToString();
        }
        else if (timeRemaining > timeToHide)
        {
            Countdown.text = "Go!";
        }
        else 
        {
            Countdown.enabled = false;
            hidden = true; 
        }
    }
	// Update is called once per frame
	void Update()
    {
        if (!hidden)
        {
            CountdownSystem();
        }
	}
}
