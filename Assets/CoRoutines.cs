using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutines : MonoBehaviour
{
    // Start is called before the first frame update
    /* int num = 0;
     IEnumerator coritine;
     void Start()
     {
         //coritine=ScoreUpdate();
         print("start");
         StartCoroutine(ScoreUpdate());

     }
     IEnumerator ScoreUpdate()
     {
         print("score" + ++num);
         yield return new WaitForSeconds(5.0f);
         print("end");
     }

     // Update is called once per frame
     private void Update()
     {
         //StartCoroutine(ScoreUpdate());
     }*/
    private void Awake()
    {
        
    }
    private void Start()
    {
        StartCoroutine(ColorTest());
        colorsTest();
    }
    IEnumerator ColorTest()
    {
        print("start corotuine");
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.green;
       yield return null;
        print(" end of coroutine");
    }
    void colorsTest()
    {
        print("start of normal function");
        GetComponent<Renderer>().material.color = Color.red;
        GetComponent<Renderer>().material.color = Color.green;
        print("start ofend function");
    }
}
