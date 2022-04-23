using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObj : MonoBehaviour
{
    public float speed = 5f;



    void Update()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }

}
