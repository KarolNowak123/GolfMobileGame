using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameControllerWinLose;

public class WinController : MonoBehaviour
{    private void OnTriggerEnter(Collider other)
    {
        WinLoseController.Instance.Win();
    }


}
