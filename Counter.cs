using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText1Point;
    public Text CounterText2Points;
    public Text CounterText3Points;
    public Text TotalScoreCounter;

    private int Count = 0;
    private int point1 = 0;
    private int point2 = 0;
    private int point3 = 0;

    private int add1;
    private int add2;
    private int add3;

    private void Start()
    {
        Count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("1Point"))
        {
            point1 += 1;
            CounterText1Point.text = "Count (1 Point): " + point1;
        }

        if (other.gameObject.CompareTag("2Points")) {
            point2 += 1;
            CounterText2Points.text = "Count (2 Points): " + point2;
        }

        if (other.gameObject.CompareTag("3Points"))
        {
            point3 += 1;
            CounterText3Points.text = "Count (3 Points): " + point3;
        }

        add1 = (point1 * 1);
        add2 = (point2 * 2);
        add3 = (point3 * 3);

        Count = (add1 + add2 + add3);
        TotalScoreCounter.text = "Total Score: " + Count;
    }
}
