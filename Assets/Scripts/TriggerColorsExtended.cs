using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColorsExtended : TriggerColors
{
    [SerializeField]
    private Color[] colors;
    private int i = 0;

    protected override void Start()
    {
        base.Start();
        triggerColor = colors[i];
        i++;
    }

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        if (triggerEnter)
        {
            if (i == colors.Length)
            {
                i = 0;
            }
            triggerColor = colors[i];
            i++;
        }
    }

    protected override void OnTriggerExit(Collider other)
    {
        base.OnTriggerExit(other);
        if (!triggerEnter)
        {
            if (i == colors.Length)
            {
                i = 0;
            }
            triggerColor = colors[i];
            i++;
        }
    }
}
