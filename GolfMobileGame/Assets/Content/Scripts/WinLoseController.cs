using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameControllerWinLose
{
    //public class WinLose
    //{
    //    public int lvlCounter=0;
    //}
    public class WinLoseController : MonoBehaviour
    {
        [SerializeField]
        GameObject[] lvl;

        [SerializeField]
        GameObject winPop;
        [SerializeField]
        GameObject losePop;

        public int lvlCounter = 0;

        GameObject lvlInstantiate;
        GameObject winPopInstantiate;
        GameObject losePopInstantiate;
        // Start is called before the first frame update


        public static WinLoseController Instance;
        public void SetLvl() { lvlCounter++; }
        public int GetLvl() { return lvlCounter; }

        private void Awake()
        {
            Instance = this;
        }

        void Start()
        {
            lvlInstantiate = Instantiate(lvl[0], new Vector3(0, 0, 0), Quaternion.identity);
        }
        public void NextLvl()
        {
            CompletedLvl();
            lvlInstantiate = Instantiate(lvl[Instance.GetLvl()], new Vector3(0, 0, 0), Quaternion.identity);
        }
        public void RetryLvl()
        {
            Destroy(lvlInstantiate);
            lvlInstantiate = Instantiate(lvl[Instance.GetLvl()], new Vector3(0, 0, 0), Quaternion.identity);
            CloseLose();
        }

        public void CompletedLvl()
        {
            Destroy(lvlInstantiate);
            Instance.SetLvl();
            CloseWin();
        }

        public void Win()
        {
            winPopInstantiate = Instantiate(winPop);
            Debug.Log("Win");

        }
        public void CloseWin()
        {
            Destroy(winPopInstantiate);
        }

        public void Lose()
        {
            losePopInstantiate = Instantiate(losePop);
            Debug.Log("Lose");
        }
        public void CloseLose()
        {
            Destroy(losePopInstantiate);   
        }
    }
}