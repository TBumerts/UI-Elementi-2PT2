using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VardaParadisana : MonoBehaviour 
{
	public int kadruSkaits = 0; 
	// Use this for initialization
	void Start ()
	{
		Debug.Log("Uzsākta programma! Tu esi"+kadruSkaits+" kadrā!");
	}

	// Update is called once per frame
	void Update()
	{
		Debug.Log("Kadrs: "+kadruSkaits);
		kadruSkaits++;
	}
}
