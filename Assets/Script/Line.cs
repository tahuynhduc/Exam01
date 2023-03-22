using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float moveSpeed;
    public float xDirection;


    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 20;
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        float moveStep = xDirection * moveSpeed * Time.deltaTime;
        //Debug.Log(moveStep);
        if ((transform.position.x <= -9 && xDirection <0 )|| (transform.position.x >= 9 && xDirection >0))
            return;
        transform.position = transform.position + new Vector3(moveStep,0,0);
    }
    
}
