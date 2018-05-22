using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReactor : MonoBehaviour {

    public GameObject go;
    public Transform dispenseLocation;



 
    public void HandlePush()
    {
        Debug.Log("Pushed");
        GameObject newGo = (GameObject) Instantiate(go, dispenseLocation.position, Quaternion.identity);
        Destroy(newGo, 10f);
    }
}

