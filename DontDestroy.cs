using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour
{

    public GameObject Coin;
    // Start is called before the first frame update
    void Awake()
    {


        DontDestroyOnLoad(Coin);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
