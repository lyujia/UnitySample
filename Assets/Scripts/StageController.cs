using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageController : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName;
    [SerializeField]
    private GameObject panelStageClear;
    private bool getAllCoins = false;
    private int maxCoinCount;
    private int currentCoinCount;
    // Start is called before the firs
    // t frame update
    public int MaxCoinCount => maxCoinCount;
    public int CurrentCoinCount => currentCoinCount; 
    void Awake()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        maxCoinCount = coins.Length;
        currentCoinCount = maxCoinCount;
        Time.timeScale = 1.0f;
        panelStageClear.SetActive(false);
    }
    public void GetCoin()
    {
        currentCoinCount--;
        if(currentCoinCount == 0)
        {
            getAllCoins = true;
            Time.timeScale = 0.0f;
            panelStageClear.SetActive(true);//stageclear;
        }

    }
    // Update is called once per frame
    void Update()
    {
        if(getAllCoins == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}
