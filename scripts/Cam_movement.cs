using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_movement : MonoBehaviour
{
public Transform target;
   
public Vector3 offset = new Vector3(-20,20,-20);
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = target.transform.position + new Vector3(0, 1, -10);
    }
}
