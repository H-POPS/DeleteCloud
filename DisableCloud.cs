using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class ToggleCloud : MonoBehaviour
{
    ScreenSpaceCloudShadow SSCS;
    void Start()
    {
        SSCS = FindObjectOfType<ScreenSpaceCloudShadow>().GetComponent<ScreenSpaceCloudShadow>();
    }

    void Update()
    {
        if (SSCS == null)
        {
            SSCS = FindObjectOfType<ScreenSpaceCloudShadow>().GetComponent<ScreenSpaceCloudShadow>();
        }
        else
        {
            SSCS.cloudiness = 0;
            SSCS.shadowColor = new Color(0, 0, 0, 0);
            SSCS.shadowIntensity = 0;
            SSCS.Refresh();
            Destroy(SSCS);
        }
    }
}
