using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The Bluetooth Library include:
using TechTweaking.Bluetooth;

public class MyDemoCube : MonoBehaviour
{
    public LpmsConnection lpmsConnection;

    private void Update()
    {
        transform.rotation = LpmsAPI.GetOrientation(lpmsConnection);
    }

    public void SelectDevice()
    {
        BluetoothAdapter.showDevices();
    }
}
