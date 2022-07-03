using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CollectableController collectableController = other.GetComponent<CollectableController>();
    
        if(collectableController != null)
        {
            collectableController.AddStar();
            gameObject.SetActive(false);
        }
    }
}
