using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public float Timers;
    void Update()
    {
        Timers += Time.deltaTime;
        if(Timers >= 5)
        {
            Destroy(this.gameObject);
        }
    }
}
