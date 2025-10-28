using Unity.VisualScripting;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    public float bpm;

    public AudioSource music;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
