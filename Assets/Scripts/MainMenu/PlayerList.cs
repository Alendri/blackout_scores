using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerList : MonoBehaviour {
    public GameObject playerListItemPrefab;
    public GameObject maxPlayersMessagePrefab;
    private GameObject maxPlayersMessage;
    void Start() {
        Signals.onPlayerAdded += PlayerAdded;
        Signals.onPlayerRemoved += PlayerRemoved;
    }

    void PlayerAdded(Player p) {
        GameObject go = Instantiate(playerListItemPrefab, gameObject.transform);
        PlayerListItem item = go.GetComponent<PlayerListItem>();
        item.SetPlayer(p);
        if (GameManager.GetPlayers().Count >= 8 && maxPlayersMessage == null) {
            maxPlayersMessage = Instantiate(maxPlayersMessagePrefab, gameObject.transform);
        }
    }
    void PlayerRemoved() {
        if (maxPlayersMessage != null) {
            Destroy(maxPlayersMessage);
        }
    }
}
