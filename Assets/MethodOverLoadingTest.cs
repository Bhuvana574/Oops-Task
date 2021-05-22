using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverLoadingTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestPrint(1.0f);
    }

   
    // Update is called once per frame
    void TestPrint()
    {
        Debug.Log("method without parameter");
    }
    void TestPrint(int i)
    {
        Debug.Log("int parameter");
    }
    void TestPrint(float i)
    {
        Debug.Log("float parameter");
    }

}
