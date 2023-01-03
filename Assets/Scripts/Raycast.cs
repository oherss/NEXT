using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Raycast : MonoBehaviour
{
    Camera cam;
    Vector3 pos = new Vector3(200, 200, 0);
    private bool doorIsOpen = false;
    


    void Start()
    {
        cam = GetComponent<Camera>();

        gameObject.tag = "Player";
        
    }

    void Update()
    {

        if (true)
        {

        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0, 0, 0));

            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 100f))
            {
                if (hit.transform != null)
                {
                    //OpenCloseDoor(hit);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Animator>().Play("DoorOpenAnimation", 0, 0.0f);

        other.GetComponent<TriggerDoorController>().changeBool();
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Animator>().Play("doorClose", 0, 0.0f);

    }
    
    private void OpenCloseDoor(RaycastHit hit)
    {
        doorIsOpen = hit.transform.GetComponent<TriggerDoorController>().getBool();
        
        if (doorIsOpen)
        {
            hit.transform.gameObject.GetComponent<Animator>().Play("doorClose",0,0.0f);
            hit.transform.gameObject.GetComponent<TriggerDoorController>().changeBool();

        }
        else
        {
            hit.transform.gameObject.GetComponent<Animator>().Play("DoorOpenAnimation",0,0.0f);
            hit.transform.gameObject.GetComponent<TriggerDoorController>().changeBool();
        }
        
        doorIsOpen = !doorIsOpen;
                
    }
      
}

