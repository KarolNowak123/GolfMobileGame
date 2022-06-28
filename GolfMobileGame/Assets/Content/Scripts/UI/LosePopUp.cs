using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameControllerWinLose;

public class LosePopUp : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnButtonClick()
    {
        WinLoseController.Instance.RetryLvl();
        Debug.Log("PopUpClose");
    }
}
