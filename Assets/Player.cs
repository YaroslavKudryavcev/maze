using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;   
    [SerializeField] Vector3 moveDirection; 
    
    [SerializeField] KeyCode keyThree;
    [SerializeField] KeyCode keyFoure;
    [SerializeField] Vector3 moveDirection2;

    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if (Input.GetKey(keyThree))
        {
            GetComponent<Rigidbody>().velocity += moveDirection2;
        }
        if (Input.GetKey(keyFoure))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection2;
        }
                 
    }
    private void OnTriggerEnter(Collider other)
    {
            if(this.CompareTag("Player") && other.CompareTag("Finish")){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
    }
}
