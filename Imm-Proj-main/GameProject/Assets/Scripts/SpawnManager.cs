using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    //access game manager
    private GameManager gameManager;
    //spawn positions for objects
    public GameObject obstaclePrefab;
    public GameObject obstaclePrefab1;
    public GameObject obstaclePrefab2;
    public GameObject obstaclePrefab3;
    public GameObject obstaclePrefab4;
    public GameObject obstaclePrefab5;
    public GameObject obstaclePrefab6;
    public GameObject obstaclePrefab7;


    //positions for obstacles
    private Vector3 spawnPos = new Vector3 (26,11, 29);
    private Vector3 spawnPos1 = new Vector3(23, 11, 40);
    private Vector3 spawnPos2 = new Vector3(28, 11, 40);
    private Vector3 spawnPos3 = new Vector3(28, 12, 44);
    private Vector3 spawnPos4 = new Vector3(23, 11, 56);
    private Vector3 spawnPos5 = new Vector3(24, 11, 99);
    private Vector3 spawnPos6 = new Vector3(29, 11, 99);
    private Vector3 spawnPos7 = new Vector3(25, 11, 65);

    private float startDelay = 15.0f;
    private float repeatRate = 15.0f;

    //access to player movement to check for game over
    private PlayerMovementX playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);   
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerMovementX>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnObstacles()
    {
        if (gameManager.isGameActive == true)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            Instantiate(obstaclePrefab1, spawnPos1, obstaclePrefab1.transform.rotation);
            Instantiate(obstaclePrefab2, spawnPos2, obstaclePrefab2.transform.rotation);
            Instantiate(obstaclePrefab3, spawnPos3, obstaclePrefab3.transform.rotation);
            Instantiate(obstaclePrefab4, spawnPos4, obstaclePrefab4.transform.rotation);
            Instantiate(obstaclePrefab5, spawnPos5, obstaclePrefab5.transform.rotation);
            Instantiate(obstaclePrefab6, spawnPos6, obstaclePrefab6.transform.rotation);
            Instantiate(obstaclePrefab7, spawnPos7, obstaclePrefab7.transform.rotation);
        }
    }


}
