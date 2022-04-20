using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour
{
    private float yPos;
    public float waterSpeed = 0.00005f;
    // Start is called before the first frame update
    void Start()
    {
        yPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
 
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }

    void RiseWater()
    {
        yPos += .28f;
    }

    public void StartRising()
    {
        InvokeRepeating("RiseWater", 1f, 1f);  //1s delay, repeat every 1s
    }
}
