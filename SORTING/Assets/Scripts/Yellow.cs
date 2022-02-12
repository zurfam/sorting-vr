using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : MonoBehaviour
{
    public GameManager gm;
    public GameObject effects;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Yellow"))
        {
            gm.Score++;
            Debug.Log("Yellow");

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
