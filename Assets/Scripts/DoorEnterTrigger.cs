using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DoorEnterTrigger : MonoBehaviour
{
    Camera cam;
    Vector3 pos = new Vector3(200, 200, 0);
    


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
        if (other.gameObject.GetComponent<Animator>())
        {
            other.gameObject.GetComponent<Animator>().Play("DoorOpenAnimation", 0, 0.0f);
        }

      

        //other.GetComponent<TriggerDoorController>().changeBool();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Animator>())
        {
            other.GetComponent<Animator>().Play("doorClose", 0, 0.0f);
        }
        

    }

}

