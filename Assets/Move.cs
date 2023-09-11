using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        //Will move towards the camera at 1.5 frames per second
        transform.localScale *= 1 + speed * Time.deltaTime;
        //If you multiply by a straight # you don't need to mention a vector

    }
}
//ADVICE: DON'T change class name AFTER it's been created. It will mess everything up