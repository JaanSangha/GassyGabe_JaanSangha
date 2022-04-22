using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRotation : MonoBehaviour
{

    // Start is called before the first frame update
    private float rotx, roty, rotz;
    private float maxY;
    private float currentHeight;
    private bool isMax, isMin = false;
    void Start()
    {
        roty = 1;
        currentHeight = transform.position.y;
        maxY = transform.position.y + 1;
    }

    // Update is called once per frame
    void Update()
    {

        //currentHeight += Mathf.PingPong(Time.time * 0.5f, 1) * 1;

        transform.Rotate(rotx, roty, rotz);
        //transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
    }
}
