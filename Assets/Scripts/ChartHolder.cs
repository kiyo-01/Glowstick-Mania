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
    //in the embedded list, first index is the measure, second index is the beat, third index is the movement type and fourth index is row number
    public List<List<float>> getChart(string chart)
    {
        switch (chart)
        {
            case "test":
                return GetTestChart();

            case "test2":
                return GetTest2Chart();

            default:
                print("invalid chart");
                return null;
        }
    }
    
    //getting the test chart
    //reference:
    //new List<float> {measure, beat, movementType, noteRowNum}
    List<List<float>> GetTestChart()
    {
        List<List<float>> chart = new List<List<float>>
        {
            new List<float> {1, 1, GetMoveId("up"), 1},

            new List<float> {1, 2, GetMoveId("up"), 2},
            
            new List<float> {1, 3, GetMoveId("up"), 3},
            
            new List<float> {1, 4, GetMoveId("up"), 4},
            
            new List<float> {2, 1, GetMoveId("down"), 1},
            
            new List<float> {2, 2, GetMoveId("down"), 2},
            
            new List<float> {2, 3, GetMoveId("down"), 3},
            
            new List<float> {2, 4, GetMoveId("down"), 4},
            
            new List<float> {3, 1, GetMoveId("left"), 1},
            
            new List<float> {3, 2, GetMoveId("left"), 2},
            
            new List<float> {3, 3, GetMoveId("left"), 3},
            
            new List<float> {3, 4, GetMoveId("left"), 4},
            
            new List<float> {4, 1, GetMoveId("right"), 1},
            
            new List<float> {4, 2, GetMoveId("right"), 2},
            
            new List<float> {4, 3, GetMoveId("right"), 3},
            
            new List<float> {4, 4, GetMoveId("right"), 4},
        };

        return chart;
    }

    List<List<float>> GetTest2Chart()
    {
        List<List<float>> chart = new List<List<float>>
        {
            new List<float> {1, 1, GetMoveId("up"), 1},

            new List<float> {1, 2, GetMoveId("up"), 2},

            new List<float> {1, 3, GetMoveId("up"), 3},
            new List<float> {1, 3, GetMoveId("left"), 1},

            new List<float> {1, 4, GetMoveId("up"), 4},
            new List<float> {1, 4, GetMoveId("left"), 2},

            new List<float> {2, 1, GetMoveId("left"), 3},
            new List<float> {2, 1, GetMoveId("down"), 1},

            new List<float> {2, 2, GetMoveId("left"), 4},
            new List<float> {2, 2, GetMoveId("down"), 2},

            new List<float> {2, 3, GetMoveId("down"), 3},
            new List<float> {2, 3, GetMoveId("right"), 1},

            new List<float> {2, 4, GetMoveId("down"), 4},
            new List<float> {2, 4, GetMoveId("right"), 2},

            new List<float> {3, 1, GetMoveId("right"), 3},

            new List<float> {3, 2, GetMoveId("right"), 4},

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
