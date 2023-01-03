using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_CubePickup : MonoBehaviour
{

    public scr_PickupManager manager;


private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.currentBookCounter++;
            gameObject.SetActive(false);
        } 
    }

    
}
