using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float Score;
    public float Timer;
    public Text tim;
    public Text score;
    public GameObject effects;
    public Text Menu;
    public GameObject MenuShow;
    
    /*void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red"))
        {
            Score++;
            Debug.Log("Red");

            Destroy(other.gameObject);  
            Instantiate(effects, new Vector3(this.gameObject.transform.position.x, this.transform.position.y, this.transform.position.z), this.gameObject.transform.rotation);
        }
        else
        {
            Score--;
            Debug.Log("No");
        }
        if (other.CompareTag("Yellow"))
        {
            Score++;
            Debug.Log("Yellow");

            Destroy(other.gameObject);  
            Instantiate(effects, new Vector3(this.gameObject.transform.position.x, this.transform.position.y, this.transform.position.z), this.gameObject.transform.rotation);
        }
        else
        {
            Score--;
            Debug.Log("No");
        }
        if (other.CompareTag("Blue"))
        {
            Score++;
            Debug.Log("Blue");

            Destroy(other.gameObject);
            Instantiate(effects, new Vector3(this.gameObject.transform.position.x, this.transform.position.y, this.transform.position.z), this.gameObject.transform.rotation);
        }
        else
        {
            Score--;
            Debug.Log("No");
        }

    }*/
    void Update()
    {
        Timer -= Time.deltaTime;
        tim.text = "Время:" + Timer.ToString();
        score.text = "Счет:" + Score.ToString();
        if (Timer <= 0)
        {
            Menu.text = "Вы померли со счетом:" + Score.ToString();
            MenuShow.gameObject.SetActive(true);
        }
    }

    
}
