using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameControllerWinLose;

public class WinController : MonoBehaviour
{
    bool check = true;
    private void OnTriggerEnter(Collider other)
    {
        if (check)
        {
            WinLoseController.Instance.Win();
            check = false;
        }
    }


}
