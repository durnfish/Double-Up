using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UGUI : MonoBehaviour
{
    public enum InfoType { Time, Exp, Level, Health }
    public InfoType type;

    Slider mySlider;
    [SerializeField] private float maxTime;

    private void Awake()
    {
        mySlider = this.GetComponent<Slider>();
    }

    private void LateUpdate()
    {
        switch (type)
        {
            case InfoType.Time:
                float curTime = Time.deltaTime;
                mySlider.value = curTime / maxTime;
                if(mySlider.value == 1)
                {
                    curTime = 0;
                    break;
                }
                break;
            case InfoType.Exp:

                break;
            case InfoType.Level:

                break;
            case InfoType.Health:

                break;
        }
    }
}
