using System.Collections;
using System.Collections.Generic;
using DaydreamElements.ObjectManipulation;
using UnityEngine;

public class RotateBehaviour : BaseInteractiveObject
{
    
    [SerializeField]
    Transform rotator;

    float spinSpeed = 0f;
    private void OnValidate()
    {
        if (rotator == null)
        {
            rotator = transform.Find("Capsule") ?? transform.Find("Capsule");
        }
    }

    // Use this for initialization
    void Start () {
        if (rotator == null)
        {
            rotator = transform.Find("Capsule") ?? transform.Find("Capsule");
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(rotator!=null)
	    rotator.transform.Rotate(new Vector3(spinSpeed * Time.deltaTime, 0f, 0f));
    }

    protected override void OnDeselect()
    {
        base.OnDeselect();
        spinSpeed = 0f;
    }

    protected override void OnSelect()
    {
        base.OnSelect();
        spinSpeed = 360f;
    }
}
