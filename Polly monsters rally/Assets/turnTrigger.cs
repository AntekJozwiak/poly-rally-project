using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnTrigger : MonoBehaviour
{
    public AudioSource navigator;
    public AudioClip call;
    public GameObject turnController;
    public string turnName;
   
    void Update()
    {
        navigator = GameObject.FindGameObjectsWithTag("Navigator")[0].GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            turnController.GetComponent<turnController>().turnName = turnName;
            navigator.clip = call;
            navigator.Play();
            Destroy(this.gameObject);
        }
    }
}
