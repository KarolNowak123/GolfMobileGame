using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Collectables
{
    public class CollectableController : MonoBehaviour
    {
        public int stars { get; set; }

        public UnityEvent<CollectableController> OnStarCollected;

        public static CollectableController Instance;
        private void Awake()
        {
            Instance = this;
        }
        public void AddStar()
        {
            stars++;
            OnStarCollected.Invoke(this);
        }
    }
}
