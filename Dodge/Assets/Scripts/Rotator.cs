using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotaionSpeed = 60;
   
   
    void Update()
    {
        transform.Rotate(0, rotaionSpeed * Time.deltaTime, 0);
    }
}
