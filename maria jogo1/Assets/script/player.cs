using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //variavel para o rigidBody
    private RigidBody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<RigidBody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
