using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coblin :Enemy
{
    private void Start()
    {
        Coblin mycoblin = new Coblin();
        mycoblin.Attack();
        Coblin redCoblin = new RedCoblin();
        redCoblin.Attack();
        Coblin blueCoblin = new BlueCoblin();
        blueCoblin.Attack();
        Coblin whiteCoblin = new WhiteCoblin();
        whiteCoblin.Attack();

    }
    public  virtual void Attack()
    {
        Debug.Log("coblin atttack");
    }
}

public class RedCoblin:Coblin
    {
    public override void Attack()
    {
        Debug.Log("Red Coblin attack");
    }
}
public class WhiteCoblin : Coblin
{
    public override void Attack()
    {
        Debug.Log("white Coblin attack");
    }
}
public class BlueCoblin : Coblin
{
    public override void Attack()
    {
        Debug.Log("blue Coblin attack");
    }
}