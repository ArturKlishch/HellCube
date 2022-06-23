using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour
{
    [SerializeField] KeyCode keyJeden;
    [SerializeField] KeyCode keyDwa;
    [SerializeField] Vector3 moveDirection;
     public bot button;

    private void FixedUpdate()
    {
        if (Input.GetKey(keyJeden))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;

        }
        if (Input.GetKey(keyDwa))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;

        }
        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if(this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
        foreach (bot button in FindObjectsOfType<bot>())
            {
                button.isPush = false;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        foreach (bot button in FindObjectsOfType<bot>())
        {
            button.isPush = true;
        }
    }

}
