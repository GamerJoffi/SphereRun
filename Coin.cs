using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text coin;

    // Start is called before the first frame update
    public void Start()
    {

        coin.text = PlayerPrefs.GetInt("Coin").ToString("Coin 0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if((col.tag == "Coin"))
        {
            Debug.Log("Coin");
        }
    }
}
