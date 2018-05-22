using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constraints : MonoBehaviour
{
    public bool X, Y, Z;

    private Vector3 startPosition;
	// Use this for initialization
	void Start ()
	{
	    startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	    Vector3 currentPos = transform.position;
	    if (X)
	    {
	        currentPos.x = startPosition.x;
	    }

	    if (Y)
	    {
	        currentPos.y = startPosition.y;
	    }

	    if (Z)
	    {
	        currentPos.z = startPosition.z;
	    }

	    transform.position = currentPos;
	}
}
