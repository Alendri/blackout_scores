using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    public GameObject addPanel;
    public RoundManager roundManger;

    public void OnAddPlayerClick() {
        if (GameManager.GetPlayers().Count < 8) {
            addPanel.SetActive(true);
        }
    }
    public void OnAddPlayerCencel() {
        addPanel.SetActive(false);
    }

    public void OnStartClick() {
        roundManger.StartRound();
    }
}
