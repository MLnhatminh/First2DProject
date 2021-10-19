using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float velocity;
    float xDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = 10;
        xDirection = Input.GetAxisRaw("Horizontal");
        // Debug.Log(xDirection);
        float moveStep = velocity * xDirection * Time.deltaTime;

        if ((transform.position.x <= -5.16f && xDirection < 0) || (transform.position.x >= 5.15f && xDirection > 0)) 
        {
            return;
        }

        transform.position = transform.position + new Vector3(moveStep, 0, 0);
        // Debug.Log(moveStep);
    }
}
