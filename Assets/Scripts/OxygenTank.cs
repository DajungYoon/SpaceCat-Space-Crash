using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenTank : MonoBehaviour
{
    
    public Slider slider;
    
    public void SetMaxOxygen(float oxygen) {
        slider.maxValue = oxygen;
        slider.value = oxygen;
    }

    public void SetOxygenLevel(float oxygen) {
        slider.value -= oxygen;
    }
}
