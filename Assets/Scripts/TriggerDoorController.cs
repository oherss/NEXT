using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    public bool somebool = false;
    
    public void changeBool()
    {
        if (somebool)
        {
            somebool = false;
        }

        if (!somebool)
        {
            somebool = true;
        }
        Debug.Log(somebool);
    }

    public bool getBool()
    {
        return somebool;
    }
    
    
    
    
    
    
    
    
    /*
    [SerializeField] private Animator doorAnimation = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                doorAnimation.Play("DoorOpenAnimation",0,0.0f);
                gameObject.SetActive(false);
            }
            else if (closeTrigger)
            {
                doorAnimation.Play("doorClose",0,0.0f);
                gameObject.SetActive(false);
            }
        }
    }
    */
}
