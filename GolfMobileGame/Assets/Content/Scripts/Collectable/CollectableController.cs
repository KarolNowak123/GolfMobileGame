using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CollectableController : MonoBehaviour
{
    public int stars { get; set; }

    public UnityEvent<CollectableController> OnStarCollected;

    public void AddStar()
    {
        stars++;
        OnStarCollected.Invoke(this);
    }
}
