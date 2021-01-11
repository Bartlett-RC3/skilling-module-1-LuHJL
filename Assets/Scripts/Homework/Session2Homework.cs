using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC3_Dog;

public class Session2Homework : MonoBehaviour
{
    // Condition variables
    private int n1 = 4;
    private int n2 = 5;

    private bool c1;
    private bool c2;
    
    // Color Names Array
    private string[] colours = {"red", "green", "blue", "yellow", "fuchsia"};

    //Class Dog
    private Dog dog1, dog2, dog3;

    // Start is called before the first frame update
    void Start()
    {
        //condition
        if (n1 % 2 == 0)
        {
            Debug.Log("n1 {0} is even" + n1.ToString());
            c1 = true;
        }

        if (n1 % 2 == 0)
        {
            Debug.Log("n1 {0} is even" + n1.ToString());
            c2 = true;
        }

        if (c1 && c2)
        {
            Debug.Log("both n1 and n2 are even");
        }

        //LOOPS 
        //FOR LOOP (counter, end condition, step)
        for (int counter = 0; counter < colours.Length; counter += 1)
        {
            Debug.Log("The current color at pos"+ counter);
            Debug.Log(""+colours[counter]);
        }

        //CLASS Dog
        {
            dog1 = new Dog("A", "Golden Retriever", 2);
            dog2 = new Dog("B", "Poodle", 3);
            dog3 = new Dog("C", "German Shepherd", 4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dog1.GetName());
        Debug.Log(dog1.GetAge());
    }
}
