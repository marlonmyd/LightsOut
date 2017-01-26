using UnityEngine;
using System.Collections;

public class aiVision : MonoBehaviour {

    public aiPatrol aiPatrol;


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="Player")
        {
            aiPatrol.isChasing = true;
        }
    }
}
