﻿using Unity.ClusterRendering;
using UnityEngine;

public class ExitApp : MonoBehaviour
{
    void Update()
    {
        if (ClusterSync.Active)
        {
            if (Input.GetKeyDown(KeyCode.Q))
                ClusterSync.Instance.ShutdownAllClusterNodes();
        }
        else
        {
            if (ClusterSync.Terminated)
                Application.Quit(0);
        }
    }
}
