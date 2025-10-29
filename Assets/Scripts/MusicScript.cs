using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicScript : MonoBehaviour
{

    bool songFinished = false;
    float songFinishedTimer = 0.0f;
    float songFinishedTime = 3.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
    }

    void changeSongFinished()
    {
        songFinished = true;
    }
}
