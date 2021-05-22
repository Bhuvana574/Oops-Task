using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarObjects : MonoBehaviour
{
    // Start is called before the first frame update
    //create a car instance
    // Car myCar=new Car();
    // Car ford = new Car();
    //public Car myBigCar;
    //public const float pi = 3.14f;
    public enum Direction
    {
        North,
        South,
        East,
        West
    }
    void Start()
    {
        Direction myDirection;
       myDirection =GetMyDirection(Direction.East);
        Debug.Log("My direction is:" +myDirection);
        myDirection = GetMyDirection(Direction.West);
        Debug.Log("My direction is:" + myDirection);


        //Car myCar = new Car(1980);
        /*  Car ford = new Car();
          Car maruthi = new Car(2020,"Maruthi");
          maruthi.Drive();*\
          /* myCar.carName = "Ford";
           myCar.makeYear = 1980;
           myCar.maxSpeed = 180.8f;
           myCar.Drive();
           myCar.Speed();
           ford.carName = "Suzuki";
           ford.makeYear = 1990;
          ford.maxSpeed = 190.8f;
         ford.Drive();
           ford.Speed();*/
    }
    Direction GetMyDirection(Direction direction)
    {
        Direction dir;
       
        dir = Direction.East;
        if(direction==Direction.East)
        {
            dir = Direction.North;
          

        }
        return dir;
      
        

    }
}
