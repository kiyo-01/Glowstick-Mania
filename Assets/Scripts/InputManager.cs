using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    EventCore eventCore;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eventCore = GameObject.Find("EventCore").GetComponent<EventCore>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    //getting input from player
    //currently uses arrow keys for testing, but will be set up for motion detection in the future
    void GetInput()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            eventCore.provideInput.Invoke("up");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            eventCore.provideInput.Invoke("down");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            eventCore.provideInput.Invoke("left");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            eventCore.provideInput.Invoke("right");
        }
    }
}
