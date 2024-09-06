using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed = 0.5f;
    public GameObject onCollectEffect;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }


    private void OnTriggerEnter(Collider other)
    {


        // Destroy yhe collectible
        Destroy(gameObject);

        // instantiate the particle effect
        Instantiate(onCollectEffect, transform.position, transform.rotation);

    }
}
