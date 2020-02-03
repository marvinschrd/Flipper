﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleBumpersActivator : MonoBehaviour
{
    invisibleBumper invisibleBumper;
    // Start is called before the first frame update
    void Start()
    {
        invisibleBumper = FindObjectOfType<invisibleBumper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            invisibleBumper.MakeVisible();
        }
    }
}
