using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lancher : MonoBehaviour
{
    [SerializeField] float launchThrusting = 0f;
    [SerializeField] float rotationSpeed = 0f;
    Rigidbody rb;
    AudioSource audioSource;
    
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        PlayerThrusting();
        PlayerRotation();
    }
    void PlayerThrusting()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
            rb.AddRelativeForce(Vector3.up * launchThrusting * Time.deltaTime);

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            else
            {
                audioSource.Stop();
            }
        }

    }
    void PlayerRotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotationSpeed);

        }
        if (Input.GetKey(KeyCode.D)) 
        {
            ApplyRotation(-rotationSpeed);

        }
    }

    void ApplyRotation(float rotateThisFrame)
    { 
       

        transform.Rotate(Vector3.forward * rotateThisFrame * Time.deltaTime);


    }
}
