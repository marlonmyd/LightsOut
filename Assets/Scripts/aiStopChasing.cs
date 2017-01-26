using UnityEngine;
using System.Collections;

public class aiStopChasing : MonoBehaviour {

    public aiPatrol aiPatrol;

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            aiPatrol.isChasing = false;
        }
    }
}
