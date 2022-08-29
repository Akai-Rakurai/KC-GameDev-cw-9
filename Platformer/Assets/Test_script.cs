using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_script : MonoBehaviour
{
    public int speed = 10;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (transform.position.x > 8) flip();
        else if (transform.position.x < -8) flip();
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,transform.position.y, transform.position.z);
    }
    int flip()
    {
        return speed *= -1;
    }
}
