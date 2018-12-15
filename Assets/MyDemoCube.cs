using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The Bluetooth Library include:
using TechTweaking.Bluetooth;

public class MyDemoCube : MonoBehaviour
{
    // Store the connection object
    public LpmsConnection lpmsConnection;

    // Select a device to connect to. The created lpmsConnection will automatically
    // connect and start receiving data from it
    public void SelectDevice()
    {
        BluetoothAdapter.showDevices();
    }

    public void ResetOrientation()
    {
        LpmsAPI.ResetOrientation(lpmsConnection);
    }

    // Every Frame, update the rotation of this cube with sensor data
    private void Update()
    {
        transform.rotation = LpmsAPI.GetOrientation(lpmsConnection);
    }
}
