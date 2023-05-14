using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField]
    private StageController stageController;
    [SerializeField]
    private GameObject coinEffectPrefab;
    private float rotateSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);        
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        GameObject clone = Instantiate(coinEffectPrefab);
        clone.transform.position = transform.position;
        stageController.GetCoin();
        Destroy(gameObject);
    }
}
