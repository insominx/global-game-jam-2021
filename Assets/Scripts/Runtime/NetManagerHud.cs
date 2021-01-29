using MLAPI;
using System.Net;
using UnityEngine;

public class NetManagerHud : MonoBehaviour
{

    private void OnGUI()
    {
        if (GUI.Button(new Rect(20, 20, 100, 20), "Start client"))
        {
            NetworkingManager.Singleton.StartClient();
        }

        if (GUI.Button(new Rect(20, 70, 100, 20), "Start server"))
        {
            NetworkingManager.Singleton.StartServer();
        }

        if (GUI.Button(new Rect(20, 120, 100, 20), "Start host"))
        {
            NetworkingManager.Singleton.StartHost();
        }
    }
}