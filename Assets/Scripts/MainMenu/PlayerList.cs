using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerList : MonoBehaviour {
    public GameObject playerListItemPrefab;
    void Start() {
        Signals.onPlayerAdded += PlayerAdded;
    }

    void PlayerAdded(Player p) {
        GameObject go = Instantiate(playerListItemPrefab, gameObject.transform);
        PlayerListItem item = go.GetComponent<PlayerListItem>();
        item.SetPlayer(p);
    }
}
