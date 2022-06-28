using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameControllerWinLose;

public class WinPopUp : MonoBehaviour
{
    
    public void OnButtonClick()
    {
        WinLoseController.Instance.NextLvl();
        WinLoseController.Instance.CloseWin();
        Debug.Log("PopUpClose");
    }


}
