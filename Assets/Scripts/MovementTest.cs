using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovementTest : MonoBehaviour {

    public int isMoving;
    public Text xtext;
    public Text downtext;
    public float x;
    public float y;
    public float z;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        x = Input.acceleration.x;
        y = Input.acceleration.y;
        z = Input.acceleration.z;


    }
        


}

