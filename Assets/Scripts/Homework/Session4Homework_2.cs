using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Homework_2 : MonoBehaviour
{
    //cube
    public GameObject Obstacle;
    //number of cubes in array
    public int numberOfCube = 5;
    //spacing in array
    public float spacing = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        //create array
        for (int i = 0; i < numberOfCube; i++)
        {
            Vector3 cubeArrayPosition = new Vector3(i * spacing, 0, 0);
            Quaternion cubeArrayRotation = Quaternion.identity;
            GameObject cubeArray = Instantiate(Obstacle , cubeArrayPosition, cubeArrayRotation);
            cubeArray.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f),
                Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
