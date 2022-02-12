using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    public GameManager gm;
    public GameObject effects;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red"))
        {
            gm.Score++;
            Debug.Log("Red");

            Destroy(other.gameObject);
            Instantiate(effects, new Vector3(this.gameObject.transform.position.x, this.transform.position.y, this.transform.position.z), this.gameObject.transform.rotation);
        }
        else
        {
            gm.Score--;
            Debug.Log("No");
            Destroy(other.gameObject);
            Instantiate(effects, new Vector3(this.gameObject.transform.position.x, this.transform.position.y, this.transform.position.z), this.gameObject.transform.rotation);
        }
    }
}
