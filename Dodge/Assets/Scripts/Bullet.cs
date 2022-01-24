using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (true)
            {
                playerController.Die();
            }
        }
    }

}
