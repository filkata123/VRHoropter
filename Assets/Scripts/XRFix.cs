using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenXRRuntimeJsons;

public class XRFix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetSteamVRRuntimeFromAvailableRuntimes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetSteamVRRuntimeFromAvailableRuntimes()
    {
        // Get the available OpenXR runtime json
        IReadOnlyDictionary<OpenXRRuntimeType, string> openXRRuntimes = OpenXRRuntimeJson.GetRuntimeJsonPaths();
        if (openXRRuntimes.ContainsKey(OpenXRRuntimeType.SteamVR))
        {
            // Use the SteamVR OpenXR runtime
            OpenXRRuntimeJson.SetRuntimeJsonPath(OpenXRRuntimeType.SteamVR);
        }
    }

    void SetCustomRuntimeJson(string jsonPath)
    {
        if (!OpenXRRuntimeJson.SetRuntimeJsonPath(jsonPath))
        {
            Debug.Log($"{jsonPath} is not available");
        }
    }
}
