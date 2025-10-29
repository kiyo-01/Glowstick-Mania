using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicScript : MonoBehaviour
{

    bool songFinished = false;
    bool songStarted = false;
    float songFinishedTimer = 0.0f;
    float songFinishedTime = 2.0f;

    public AudioSource audioPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartSong();
    }

    // Update is called once per frame
    void Update()
    {
        if (songFinished)
        {
            songFinishedTimer += 1 * Time.deltaTime;

            if (songFinishedTimer > songFinishedTime)
                SceneManager.LoadScene(2);
        }

        if (!audioPlayer.isPlaying && songStarted)
        {
            songFinished = true;
        }
    }

    void StartSong()
    {
        songStarted = true;
        audioPlayer.Play();
    }
}
