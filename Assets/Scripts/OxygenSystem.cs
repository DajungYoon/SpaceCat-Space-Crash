using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenSystem : MonoBehaviour
{

    public float maxOxygen = 40.0F;
    public float oxygenLevel;
    public OxygenTank oxygen;

    // Start is called before the first frame update
    void Start()
    {
        oxygenLevel = maxOxygen;
        oxygen.SetMaxOxygen(maxOxygen);
    }

    // Update is called once per frame
    void Update()
    {
        // if o2 level greater than 0
        if (oxygen.slider.value > 0) {

            // decrease o2 level
            oxygen.SetOxygenLevel((float) 0.0077F);
        }

        // if o2 level is 0
        else if (oxygen.slider.value <= 0) {

            // remove a hert 
            HeartSystem.num_hearts += -1;

            // set o2 back to full
            oxygen.slider.value = maxOxygen;
        }
    }
}
