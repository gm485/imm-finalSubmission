using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed = 5;
    private PlayerMovementX playerControllerScript;
    //destroy prefab items that leave the map
    private float enemyBounds = 0.5f;
    private GameManager gameManager;
    

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerMovementX>();
        //access the game manager script for
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if(transform.position.z < enemyBounds && gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            
        } else if(gameManager.isGameActive == false)
            {
            Destroy(gameObject);   
        }
        
        
        
    }
}
