using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform CarPosition;
    public Vector3 cameraditance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = CarPosition.position - cameraditance;
    }
}
