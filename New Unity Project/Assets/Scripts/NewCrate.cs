using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCrate : MonoBehaviour
{

    // Use this for initialization
    private int counter = 10;


    void Start()
    {
        
        InvokeRepeating("CreateNewCube", 1f, 1f);  //1s delay, repeat every 1s
        /*cube2.GetComponent<Renderer>().material.color = Color.red;
        cube2.transform.position = new Vector3(-17, 3, 25);*/
        //print(cube.transform.position);
        //print(trig);
        /* while (Vector3.Distance(cube.transform.position, trig) > 5)
         {
             print("OKAY");
            // Newcube();
         }*/
    }
    void OutputTime()
    {
        Debug.Log(Time.time);
    }

    void CreateNewCube()
    {
        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        int colorId = Random.Range(0, 1);
        
        //Debug.Log("Couleur " + colorId);

        switch (colorId)
        {
            case 0:
                //print("color blue");
                cube.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 1:
                //print("color red");
                cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            default:
                //print("Incorrect intelligence level.");
                break;
                //var cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        }
                // color is controlled like this
                
        cube.transform.position = new Vector3(6, 3, -17);
        cube.name = "1";
        Rigidbody gameObjectsRigidBody = cube.AddComponent<Rigidbody>(); // Add the rigidbody.
        gameObjectsRigidBody.mass = 1; // Set the GO's mass to 5 via the Rigidbody.

        if (--counter == 0)
            CancelInvoke("CreateNewCube");
        //var trig = new Vector3(-20, 3, 25);
    }

    /*IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            OutputTime();
        }
    }
    void OutputTime()
    {
        Debug.Log(Time.time);
    }*/
    void Update()
    {

        //start();
       /* var trig = new Vector3(-17, 3, 28);
        //print(cube.transform.position);
        //StartCoroutine(Newcube());
        var cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // color is controlled like this
        cube1.GetComponent<Renderer>().material.color = Color.black;
        cube1.transform.position = new Vector3(-17, 3, 28);
       // cube1.name = "%d" i;
        Rigidbody gameObjectsRigidBody1 = cube1.AddComponent<Rigidbody>(); // Add the rigidbody.
        gameObjectsRigidBody1.mass = 1;
        print(cube1.name);
        // print(Vector3.Distance(GameObject.Find("1").transform.position, trig));

        yield return new WaitUntil(() => Vector3.Distance(cube1.transform.position, trig) > 5);*/

    }
    // Update is called once per frame
   /* IEnumerator Newcube()
    {
        print("OKNewcube");
        //for (var j =0; j< 1; j++)
        int i = 1;
        var trig = new Vector3(-17, 3, 28);
        //{
        //yield return new WaitForSecondsRealtime(1);
        
        print("YO O O O ");
        var cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // color is controlled like this
        cube1.GetComponent<Renderer>().material.color = Color.black;
        cube1.transform.position = new Vector3(-17, 3, 28);
        //cube1.name = "%d";
        Rigidbody gameObjectsRigidBody1 = cube1.AddComponent<Rigidbody>(); // Add the rigidbody.
        gameObjectsRigidBody1.mass = 1;
        print(cube1.name);
       // print(Vector3.Distance(GameObject.Find("1").transform.position, trig));
        
        yield return new WaitUntil(() => Vector3.Distance(cube1.transform.position, trig) > 5);
        //ConvoyerBelt convoyerBelt = cube1.GetComponent<ConvoyerBelt>();
        // print(convoyerBelt.belt.transform.position);
        //print(cube1.transform.position);
         /*while (Vector3.Distance(cube1.transform.position, convoyerBelt.belt.transform.position) <15 )
         {

             //transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);

             yield return null;
         }*/


        //print("OK");

     //}
        //}

    //}
}





