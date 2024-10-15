using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; 
    public float rotationSpeed = 45f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
            float inputZ = Input.GetAxis("Vertical"); 
             Debug.Log(inputZ);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * inputZ);

            float inputX = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up * inputX * inputZ * Time.deltaTime * rotationSpeed * 5);
    }
}
