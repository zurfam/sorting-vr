using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dvij : MonoBehaviour
{
    public float Speed;
    void Start()
    {
        
    }

    void Update()
    {
        this.gameObject.transform.position += new Vector3(-Speed * Time.deltaTime, 0, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Speed = 0;
        }
        /*if(other.tag == "Player")
        {
            
        }*/
    }
}
