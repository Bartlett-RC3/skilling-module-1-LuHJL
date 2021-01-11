using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Session4Homework : MonoBehaviour
{
    //Variables
    
    //moving
    private Boolean moving;
    //store the object abt ray cast hitting
    private RaycastHit objectSeen;
   

    // Start is called before the first frame update
    void Start()
    {
        moving = true;

    }

    // Update is called once per frame
    void Update()
    {

        moveCube();

        deleteObstacle();

        stopMoving();
    }

    //move the cube along z axis
    void moveCube()
    {
        if (moving == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime);
            Debug.Log("cube is moving");
        }

        
    }

    //stop when the cube hits the obstacle
    void deleteObstacle()
    {
        Vector3 pos = transform.position;
        Vector3 dir = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(pos, dir, out objectSeen ))
        {
            Destroy(objectSeen.transform.gameObject);
        }
    }


    void stopMoving()
    {
        if (Input.GetKeyDown("space") | Input.GetMouseButton(0))
        {
            moving = false;
            Debug.Log("cube stops moving");
        }

    }


}
