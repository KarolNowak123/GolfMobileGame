using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Player,this.transform);
        
    }

    // Update is called once per frame
}
