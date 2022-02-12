using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mertv : MonoBehaviour
{
    public GameManager gm;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        gm.Score--;
    }
}
