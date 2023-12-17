using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementX : MonoBehaviour
    
{
    public float speed = 10.0f;
    public float jumpForce = 50.0f;
    public float turnSpeed;
    
    private GameObject focalPoint;
    public float gravityModifier;
    public bool isOnGround = true;
    private Rigidbody playerRb;
    public float zRange = 0;
    public float yRange = 9.50f;
    public bool gameOver = false;
    public bool levelCompletion = false;
    private GameManager gameManager;
    public ParticleSystem explosionParticle;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
        Physics.gravity *= gravityModifier;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        //controller for movements
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            explosionParticle.Play();
        }

        //end game if they fall off the platform 
        if (transform.position.y < yRange)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
            gameManager.GameOver();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("enemies"))
        {
            Destroy(gameObject);
            gameOver = true;
            gameManager.GameOver();
            Debug.Log("Game Over");
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            levelCompletion = true;
            Debug.Log("Level Complete");
            gameManager.WinGame();
            

        }
    }
}
