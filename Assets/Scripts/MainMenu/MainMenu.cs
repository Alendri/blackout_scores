using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    public GameObject addPanel;
    public RoundManager roundManger;
    public Button startBtn;

    void Awake() {
        startBtn.onClick.AddListener(OnStartClick);
        startBtn.interactable = false;
        Signals.onPlayerAdded += (Player p) => UpdateUI();
        Signals.onPlayerRemoved += () => UpdateUI();
    }

    public void OnAddPlayerClick() {
        if (GameManager.GetPlayers().Count < 8) {
            addPanel.SetActive(true);
        }
    }
    public void OnAddPlayerCencel() {
        addPanel.SetActive(false);
    }

    public void OnStartClick() {
        roundManger.InitRound();
    }

    private void UpdateUI() {
        startBtn.interactable = GameManager.GetPlayers().Count > 1;
    }
}
