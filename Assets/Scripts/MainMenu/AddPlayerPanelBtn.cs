using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPlayerPanelBtn : MonoBehaviour {
    private int icon_index;
    private MainMenu mainMenu;
    void Awake() {
        var icon = GetComponent<Image>();
        mainMenu = GetComponentInParent<MainMenu>();
        icon_index = GameManager.AddIcon(icon.sprite);
    }
    public void OnClick() {
        GameManager.AddPlayer(icon_index);
        mainMenu.OnAddPlayerCencel();
    }
}
