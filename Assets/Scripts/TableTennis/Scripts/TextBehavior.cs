using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBehavior : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = Player.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(Player.transform.position - v);
        transform.Rotate(0, 180, 0);
    }
}
