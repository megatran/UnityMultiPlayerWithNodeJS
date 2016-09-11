using UnityEngine;

using System.Collections;

using SocketIO;
using System;

public class Network : MonoBehaviour
{



    static SocketIOComponent socket;
    public GameObject playerPrefab;

    void Start()
    {

        socket = GetComponent<SocketIOComponent>();

        socket.On("open", OnConnected);
        socket.On("spawn", OnSpawned);

    }


    void OnConnected(SocketIOEvent e)
    {

        Debug.Log("connected");

        socket.Emit("move");

    }


    void OnSpawned(SocketIOEvent e)
    {
        Debug.Log("Spawn");
        Instantiate(playerPrefab);
    }


}