using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runCode : MonoBehaviour
{
    public GameObject testBlock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "block")
        {
            Debug.Log("hello");
            testBlock.transform.position += new Vector3(0, 2, 0);
            other.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
