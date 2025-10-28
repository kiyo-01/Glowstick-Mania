using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class Conductor : MonoBehaviour
{
    
    public float bpm; //bpm of song
    public float secPerBeat; //how many seconds each beat takes
    public float songPosition; //current song position in seconds
    public float songPositionInBeats; //current song position in beats
    public float dspSongTime; //how many seconds passed since the song started0
    public List<Note> chart = new List<Note>(); //list that holds the notes with its measures, beat and type
    public AudioSource music; //the music

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        music = GetComponent<AudioSource>();

        //get the amount of seconds per beat based on bpm
        secPerBeat = 60f / bpm;

        //get the amount of time since song started
        dspSongTime = (float)AudioSettings.dspTime;

        music.Play(); //play the music
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
