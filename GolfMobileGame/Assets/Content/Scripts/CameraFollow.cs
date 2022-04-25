using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 offset;
    [SerializeField]
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = GetComponent<Transform>();
        offset = cameraTransform.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.transform.position);
        cameraTransform.transform.position = player.transform.position + offset;
    }
}
