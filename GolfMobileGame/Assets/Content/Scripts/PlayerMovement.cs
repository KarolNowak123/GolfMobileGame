using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Touch theTouch;
    private Vector2 startPosition, endPosition;
    private Vector3 shootPlayer;
    private bool movePlayer;
    private Vector3 previousPosition;

    [SerializeField]
    private Rigidbody playerTransform;
    [SerializeField]
    private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0 && playerTransform.velocity.x == 0 && playerTransform.velocity.z == 0)
        {
            theTouch = Input.GetTouch(0);
            if(theTouch.phase == TouchPhase.Began)
            {
                startPosition = theTouch.position;
            }
            if(theTouch.phase == TouchPhase.Ended)
            {
                Debug.Log(movePlayer);
                endPosition = theTouch.position;
                movePlayer = true;
            }
        }
        
        if(movePlayer)
        {
            shootPlayer.x = (endPosition.y - startPosition.y) ;
            shootPlayer.z = (endPosition.x - startPosition.x) * -1;
            shootPlayer.y = 0;

            playerTransform.AddForce(shootPlayer *-1 * moveSpeed);
            movePlayer = false;
            //playerTransform.AddForce += (endPosition.y - startPosition.y) * moveSpeed * Time.deltaTime;
        }

        //Debug.Log(startPosition);
    }
}
