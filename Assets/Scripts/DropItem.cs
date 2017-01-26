using UnityEngine;
using System.Collections;

public class DropItem : MonoBehaviour {



    void OnTriggerEnter(Collider col)
    {
        //destroy on collision
        if (col.gameObject.tag=="Player")
        {
            Destroy(this.gameObject);
            
        }
    }

}
