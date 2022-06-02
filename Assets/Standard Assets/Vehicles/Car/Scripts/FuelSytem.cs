using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelSytem : MonoBehaviour
{
    public Slider FuelSlider;
    public float CurrentFuel = 100f;
    public Text FuelDisplay;
    bool CarIsMoving;
    float CountDown = 1f;
    public float BaseInterval = 1f;
    public static FuelSytem tfs;
    // Start is called before the first frame update
    void Start()
    {
        tfs = this;
        CountDown = BaseInterval; 
    }

    // Update is called once per frame
    void Update()
    {
        if (CarIsMoving)
        {
            if (CountDown > 0) 
            {
                CountDown -= Time.deltaTime;
            }
            else
            {
                CountDown = BaseInterval;
                CurrentFuel -= 1f;
            }
        }
        FuelDisplay.text = "" + CurrentFuel;
        FuelSlider.value = CurrentFuel / 100;
    }
    public void setMovement(bool YesOrNo)
    {
        CarIsMoving = YesOrNo;
    }
}
