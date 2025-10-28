using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class ChartHolder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //gets the chart
    //charts are stored in a 2d float array, where each index holds another float list which holds the values that represent a note
    //in the embedded list, first index is the measure, second index is the beat and the third index is the movement type
    public List<List<float>> getChart(string chart)
    {
        switch (chart)
        {
            case "test":
                return GetTestChart();

            default:
                print("invalid chart");
                return null;
        }
    }
    
    List<List<float>> GetTestChart()
    {
        List<List<float>> chart = new List<List<float>>
        {
            new List<float> {1, 1, GetMoveId("up")},
            new List<float> {1, 2, GetMoveId("down")},
            new List<float> {1, 3, GetMoveId("left")},
            new List<float> {1, 4, GetMoveId("right")},
            new List<float> {2, 1, GetMoveId("up")},
            new List<float> {2, 2, GetMoveId("down")},
            new List<float> {2, 3, GetMoveId("left")},
            new List<float> {2, 4, GetMoveId("right")},
        };

        return chart;
    }

    //converts the move type from a string to a float so it can be read by conductor
    float GetMoveId(string moveType)
    {
        switch (moveType)
        {
            case "up":
                return 1;

            case "down":
                return 2;

            case "left":
                return 3;

            case "right":
                return 4;
            
            default:
                return -1;
        }
    }
}
