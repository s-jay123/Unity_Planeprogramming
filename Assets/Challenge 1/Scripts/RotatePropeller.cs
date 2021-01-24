using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotationSpeed= 300.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        //rotation on Z axis,
        transform.Rotate(0,0, rotationSpeed * Time.deltaTime);



    }
}
