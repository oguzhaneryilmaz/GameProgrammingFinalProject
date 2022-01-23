using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject Meteorite;

    void Start()
    {
        InvokeRepeating("inst",1f,0.5f);
    }



    void Update()
    {
        
    }

    void inst(){
        var position = new Vector3(Random.Range(-5.0f, 5.0f), 4.5f, 0);
        Instantiate(Meteorite, position, Quaternion.identity);
    }

    

}
