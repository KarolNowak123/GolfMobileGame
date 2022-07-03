using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Collectables;
public class StarsWin : MonoBehaviour
{
    private TextMeshProUGUI starCounter;
    [SerializeField]
    GameObject[] images;
    // Start is called before the first frame update
    void Start()
    {
        starCounter = GetComponent<TextMeshProUGUI>();
        StarPop();
    }
    void StarPop()
    {
        Debug.Log(CollectableController.Instance.stars);
        switch(CollectableController.Instance.stars)
        {
            case 1:
                images[0].SetActive(true);
                break;
            case 2:
                images[0].SetActive(true);
                images[1].SetActive(true);
                break;
            case 3:
                images[0].SetActive(true);
                images[1].SetActive(true);
                images[2].SetActive(true);
                break;
            default:
                break;

        }
    }
    
}
