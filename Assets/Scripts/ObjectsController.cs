using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectsController : MonoBehaviour
{
    [SerializeField] private GameObject Sun;
    [SerializeField] private float speed;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);

        
    }
}
