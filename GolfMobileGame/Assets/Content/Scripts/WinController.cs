using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinController : MonoBehaviour
{
    [SerializeField]
    WinLoseController winLoseController;

    private void OnTriggerStay(Collider other)
    {
        winLoseController.Win();
    }


}
