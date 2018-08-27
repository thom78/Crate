using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SubCountCrate : MonoBehaviour
{
    public int subScore = 0;
    public GameController gameController;

    void start()
    {
       
    }

    private void OnTriggerStay(Collider other)
    {
        
            
        gameController = GameObject.FindObjectOfType(typeof(GameController)) as GameController;
        //Debug.Log();
        Color color = other.GetComponent<Renderer>().material.color;
        print("Arrival color" + this.GetComponent<Renderer>().material.color);
        print("crate color" + color);

        if (color == this.GetComponent<Renderer>().material.color)
        {
            //print("color blue");
            Destroy(other);
            subScore = 1;
            gameController.AddScore(subScore);
            //Debug.Log(subScore);
            subScore = 0;

        } 
        else
        {
            print("Incorrect intelligence level.");
        }
          
                //var cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
       
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
