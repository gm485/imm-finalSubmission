using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //access game manager
    public GameObject Player;
    private Vector3 offset = new Vector3(0 , 4, -10);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Late Update is called to smooth the camera transition
    void LateUpdate()
    {
            transform.position = Player.transform.position + offset;
    }
}
