using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaflLapScipt : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject Rain;

    void OnTriggerEnter()
    {
        LapCompleteTrig.SetActive(true);
        HalfLapTrig.SetActive(false);
        Rain.SetActive(true);
    }

}
