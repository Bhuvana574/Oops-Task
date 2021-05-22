using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class AttributeTest : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField]
    //[HideInInspector]
    [Range(0, 9)]
   Rigidbody rb;
    
    public  int speed;
    private void Awake()
    {
        gameObject.AddComponent<Rigidbody>();
    }
    private void Start()
    {
        //gameObject.AddComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(speed *Time.deltaTime, 0, 0);
        rb.isKinematic=false;
    }
}
