using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    public GameObject addPanel;

    public void OnAddPlayerClick() {
        addPanel.SetActive(true);
    }
    public void OnAddPlayerCencel() {
        addPanel.SetActive(false);
    }

    public void OnStartClick() {

    }
}
