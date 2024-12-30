using UnityEngine;
using Mirror; // Example: Using Mirror for networking

public class NetworkManager : Mirror.NetworkManager
{
    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        GameObject player = Instantiate(playerPrefab);
        NetworkServer.AddPlayerForConnection(conn, player);
    }
}

