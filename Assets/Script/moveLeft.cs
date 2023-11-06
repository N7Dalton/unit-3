using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    private float speed = 30;
    private playerController playerControllerScript;




    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<playerController>();

    }

    private float leftBound = -15;

    void Update()
    {
       
        
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

    }
}
