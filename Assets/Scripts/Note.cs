using UnityEngine;

public class Note : MonoBehaviour
{
    //the measure this note will play
    public int measure;

    //the beat this note will play
    public int beat;

    //the type of note that will show up
    //for the actual glowstick mania, this will be the movement
    public string type;
    
    void Initialize(int tempMeasure, int tempBeat, string tempType)
    {
        measure = tempMeasure; 
        beat = tempBeat;
        type = tempType;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
