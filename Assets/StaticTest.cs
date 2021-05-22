using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    // Start is called before the first frame update
    static int score = 0;
     void IncrementScore()
    {
        Debug.Log("updated score:" + score++);
    }
    void Start()
    {
      StaticTest myTest = new StaticTest();
        myTest.IncrementScore();
       
    }

    // Update is called once per frame
    void Update()
    {
        IncrementScore();
    }
}
