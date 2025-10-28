using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    //public UnityEvent 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown)
    }

    //getting input from player
    //currently uses arrow keys for testing, but will be set up for motion detection in the future
    void getInput()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
}
