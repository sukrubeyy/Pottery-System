using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemRotate : MonoBehaviour
{
    public float speed;
    void Start()
    {
       
    }
    private void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
