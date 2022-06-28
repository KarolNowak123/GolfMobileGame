using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Touch theTouch;
    private Vector2 startPosition, endPosition;
    private Vector3 shootPlayer;
    private bool movePlayer = false;
    private Vector3 previousPosition;

    [SerializeField]
    private Rigidbody playerTransform;
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float stopBall;
    [SerializeField]
    private Transform cameraRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0 && playerTransform.velocity.x < 0.02 && playerTransform.velocity.z < 0.02)
        {
            movePlayer = TouchControler();
        }
        if (movePlayer)
        {
            MovePlayer();
            movePlayer = false;
        }
        if(playerTransform.velocity.magnitude<stopBall)
        {
            playerTransform.velocity = Vector3.zero;
        }
     
     }

    void MovePlayer()
    {
        
            shootPlayer.x = (endPosition.y - startPosition.y);
            shootPlayer.z = (endPosition.x - startPosition.x) * -1;

        shootPlayer.y = 0;
        //shootPlayer.x = (float)(shootPlayer.x * Math.Cos(cameraRotation.rotation.x ) - shootPlayer.z * Math.Sin(cameraRotation.rotation.y ));
        //shootPlayer.z = (float)(shootPlayer.x * Math.Sin(cameraRotation.rotation.x ) + shootPlayer.z + Math.Cos(cameraRotation.rotation.y ));
        //shootPlayer *= Quaternion.Angle(new Quaternion(0f, 0f, 0f, 0f), cameraRotation.rotation);

    

        playerTransform.AddForce(shootPlayer * -1 * moveSpeed);
            //playerTransform.AddForce += (endPosition.y - startPosition.y) * moveSpeed * Time.deltaTime;
    }
    bool TouchControler()
    {

        theTouch = Input.GetTouch(0);
        if (theTouch.phase == TouchPhase.Began)
        {
            startPosition = theTouch.position ;
            Debug.Log(theTouch.position);
        }
        if (theTouch.phase == TouchPhase.Ended)
        {
            
            //Debug.Log(movePlayer);
            endPosition = theTouch.position ;
            movePlayer = true;
        }

        return movePlayer;
    }
}
