using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestoy : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if ((col.tag == "Player"))
        {
            Destroy(this);



        }
    }

}
