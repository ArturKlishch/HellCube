using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bot : MonoBehaviour
{
    public GameObject[] firstGroup;
    public GameObject[] secondGroup;
    public bot button;
    public bool isPush;
    public Material normal;
    public Material transparent;
    

    private void OnTriggerEnter(Collider other)
    {
        if (isPush)
        {
            if (other.CompareTag("Cube") || other.CompareTag("Player"))
            {
                foreach (GameObject fisrt in firstGroup)
                {
                    fisrt.GetComponent<Renderer>().material = normal;
                    fisrt.GetComponent<Collider>().isTrigger = false;
                }
                foreach (GameObject second in secondGroup)
                {
                    second.GetComponent<Renderer>().material = transparent;
                    second.GetComponent<Collider>().isTrigger = true;
                }
                GetComponent<Renderer>().material = transparent;
                button.GetComponent<Renderer>().material = normal;
                button.isPush = true; 
            }
        }
    }

}
