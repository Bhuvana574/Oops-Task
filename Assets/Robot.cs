using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//is A derived class
public class Robot:Enemy
{
    public bool isAttacking = false;
    public void Update()
    {
        if(isAttacking)
        {
            Attack();
            //base.Attack();
        }
    }
    void Attack()
    {
        Debug.Log("this is robot attack");
    }
}
