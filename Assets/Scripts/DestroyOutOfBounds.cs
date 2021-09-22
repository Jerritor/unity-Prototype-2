using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //destroy at top or bottom
        if (transform.position.z > topBound || transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");

            //Deinstantiates gameobject
            Destroy(gameObject);
        }
    }
}
