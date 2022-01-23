using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotStopMusic : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
