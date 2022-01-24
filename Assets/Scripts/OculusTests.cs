using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;
using OVR;
public class OculusTests : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("BOundary configured: " + OVRManager.boundary.GetConfigured());

    }
}
