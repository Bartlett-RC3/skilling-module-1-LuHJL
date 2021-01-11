using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour
{

    //variables

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCube();
        if (Input.GetMouseButtonDown(0)) 
                ChangeColor();
    }


    //move the cube across the screen
    void MoveCube()
    {
        Vector3 moveCube = new Vector3(1, 0, 0);
        this.GetComponent<Transform>().Translate(moveCube * Time.deltaTime);
    }

    void ChangeColor()
    {
        Color cubeNewColor = new Color(Random.Range( 0.0f,1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        this.GetComponent<MeshRenderer>().material.color = cubeNewColor;
    }
}
