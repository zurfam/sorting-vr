using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] Cubes = new GameObject[3];
    private int i;
    private float tk;
    public float Timerss;

    void Update()
    {
        tk += Time.deltaTime;
        if(tk >= Timerss)
        {
            i = Random.Range(0, 3);
            Instantiate(Cubes[i],new Vector3(4,1,0.09f),this.transform.rotation);
            tk = 0;
        }
    }
}
