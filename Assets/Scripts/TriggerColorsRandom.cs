using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColorsRandom : TriggerColors
{
    [SerializeField]
    private Color[] colors; 

    protected override void Start()
    {
        base.Start();
        colors[0] = mainColor;
        colors[1] = triggerColor;
    }

    protected override void OnTriggerEnter(Collider other)
    {
        if (triggerEnter)
        {
            triggerColor = colors[Random.Range(0, colors.Length)];
        }
        base.OnTriggerEnter(other);       
    }

    protected override void OnTriggerExit(Collider other)
    {
        if (!triggerEnter)
        {
            triggerColor = colors[Random.Range(0, colors.Length)];
        }
        base.OnTriggerExit(other);
    }
}
