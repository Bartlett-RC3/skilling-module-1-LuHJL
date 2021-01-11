using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour {

	// Use this for initialization
	void Start () {

	 // int
     int intVariable = 1;

	 //float
     float floatVariable = 1.0f;

	 //string
     string stringVariable = "Lu";

	 //print
     Console.WriteLine(intVariable + floatVariable + stringVariable);

	 //array
     int[]arrayNumbers = new int[]{12,13,14};

	 //list
     List<int> listNumers = new List<int>();

	 //dictionary
	 Dictionary<string,string> newDictionary = new Dictionary<string, string>();
	 newDictionary.Add("a","1");
     newDictionary.Add("b","2");
	 


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
