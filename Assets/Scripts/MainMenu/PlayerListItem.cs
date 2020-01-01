using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerListItem : MonoBehaviour {
    public TextMeshProUGUI title;
    public Image icon;
    private Player p;

    void Start() {
        Signals.onPlayerRemoved += OnPlayerRemoved;
    }
    void OnDestroy() {
        Signals.onPlayerRemoved -= OnPlayerRemoved;
    }

    public void SetPlayer(Player p) {
        this.p = p;
        title.SetText("Player " + (p.index + 1));
        icon.sprite = GameManager.GetIcon(p.icon_index);
    }

    public void OnDeleteClick() {
        if (p == null) {
            return;
        }
        GameManager.RemovePlayer(p);
        Destroy(gameObject);
    }

    void OnPlayerRemoved() {
        title.SetText("Player " + (p.index + 1));
    }
}
