using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueaPlayingMusic : MonoBehaviour
{
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
