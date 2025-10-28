using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    public float points = 0;
    public Transform cameraTransform;
    float newCameraTransform = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newCameraTransform = cameraTransform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        points = Mathf.Clamp(points, -6, 5);

        Vector3 cameraOriginal = cameraTransform.position;


        cameraOriginal.z = Mathf.Lerp(cameraOriginal.z, newCameraTransform, 2.0f * Time.deltaTime);

        cameraTransform.position = cameraOriginal;
        

        if (points < -5)
        {
            SceneManager.LoadScene(3);
        }
    }

    void PointChange(float pointChange)
    {
        points += pointChange;
        if (points > -5 && points <= 5)
        {
            newCameraTransform = -10f + points;
        }
        
        Debug.Log(newCameraTransform);
    }

    public void DebugButtonPoints(float pointChange)
    {
        PointChange(pointChange);
    }
}
