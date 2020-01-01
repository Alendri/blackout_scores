using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerListItem : MonoBehaviour {
    public TextMeshProUGUI title;
    public Image icon;
    private Player p;
    public void SetPlayer(Player p) {
        this.p = p;
        title.SetText("Player " + (p.id + 1));
        icon.sprite = GameManager.GetIcon(p.icon_index);
    }

    public void OnDeleteClick() {
        if (p == null) {
            return;
        }
        Debug.Log("test");
        GameManager.RemovePlayer(p);
        Destroy(gameObject);
    }
}
