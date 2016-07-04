using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class ToggleCloud : MonoBehaviour
{
    internal void DisableClouds()
    {
        ScreenSpaceCloudShadow SSCS = FindObjectOfType<ScreenSpaceCloudShadow>().GetComponent<ScreenSpaceCloudShadow>();
        SSCS.cloudiness = 0;
        SSCS.enabled = false;

    }
}
