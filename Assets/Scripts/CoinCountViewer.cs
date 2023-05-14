using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinCountViewer : MonoBehaviour
{   [SerializeField]
    private StageController stageController;
    private TextMeshProUGUI textCoinCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textCoinCount.text = "Coins : " + stageController.CurrentCoinCount + "/" + stageController.MaxCoinCount;
    }
}
