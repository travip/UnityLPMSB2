using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Wrapper class around LpmsConnection functions to simplify
public static class LpmsAPI
{
    // Return the current orientation of a sensor 
    public static Quaternion GetOrientation(LpmsConnection conn)
    {
        return conn.sensorOrientation;
    }

    // Reset the orientation of a sensor
    public static void ResetOrientation(LpmsConnection conn)
    {
        conn.SetOrientationOffset(0);
    }
}
