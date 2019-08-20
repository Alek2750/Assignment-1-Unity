using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 10.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float translation = Input.GetAxis("Vertical") * speed;
        

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

    }
}
