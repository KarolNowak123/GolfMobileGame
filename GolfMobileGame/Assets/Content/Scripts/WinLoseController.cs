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
        
        public int lvlCounter = 0;

        GameObject lvlInstantiate;
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
            lvlInstantiate = Instantiate(lvl[Instance.GetLvl()], new Vector3(0, 0, 0), Quaternion.identity);
        }

        public void CompletedLvl()
        {
            Destroy(lvlInstantiate, 1.0f);
            Instance.SetLvl();
            NextLvl();
        }

        public void Win()
        {
            winPop.SetActive(true);
            Debug.Log("Win");

        }
        public void CloseWin()
        {
            winPop.SetActive(false);
        }

        public void Lose()
        {
            Debug.Log("Lose");
        }
        
    }
}