using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
public class Collectable : MonoBehaviour
{
    private TextMeshProUGUI starCounter;
    // Start is called before the first frame update
    void Start()
    {
        starCounter = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateStarCount(CollectableController collectableController)
    {
        starCounter.text = collectableController.stars.ToString();
    }
}
