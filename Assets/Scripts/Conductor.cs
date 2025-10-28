using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class Conductor : MonoBehaviour
{
    [Header("References")]
    public ChartHolder chartHolder;
    public AudioSource music; //the music

    [Header("Conductor")]
    public float bpm; //bpm of song
    public List<List<float>> chart = new List<List<float>>(); //list that holds the notes with its measures, beat and type

    [Header("Conductor Stats")]
    [SerializeField] float secPerBeat; //how many seconds each beat takes
    [SerializeField] float songPosition; //current song position in seconds
    [SerializeField] int totalBeats; //the total amount of beats in a song
    [SerializeField] int currentMeasure; //current measure of the song
    [SerializeField] float currentBeat; //current beat of the song
    [SerializeField] float dspSongTime; //how many seconds passed since the song started

    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        music = GetComponent<AudioSource>();
        secPerBeat = 60f / bpm; //get the amount of seconds per beat based on bpm
        dspSongTime = (float)AudioSettings.dspTime; //get the amount of time since song started

        chart = chartHolder.getChart("test"); //get the test chart
        music.Play(); //play the music
    }

    // Update is called once per frame
    void Update()
    {
        //determine the song position by checking how many seconds have passed since the song started
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);

        //get the total amount of beats in the song
        totalBeats = Mathf.FloorToInt(songPosition / secPerBeat);

        //get the current measure and beat of the song
        currentMeasure = (int)totalBeats / 4 + 1;
        currentBeat = (totalBeats % 4) + 1;

        if (chart[0][0] == currentMeasure && chart[0][1] == currentBeat)
        {
            print(chart[0][0] + ", " + chart[0][1] + ", " + chart[0][2]);
            chart.Remove(chart[0]);
        }
    }
}
