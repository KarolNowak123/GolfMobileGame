using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    GameObject lvl;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(lvl,new Vector3(0,0,0),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
