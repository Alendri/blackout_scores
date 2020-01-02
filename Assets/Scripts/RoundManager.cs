using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour {
    public CardAmountPanel cardAmountPanel;

    void Start() {
        gameObject.SetActive(false);
    }
    public void InitRound() {
        gameObject.SetActive(true);
        cardAmountPanel.Show(StartRound);
    }

    public void StartRound(int card_amt) {
        Round r = new Round(card_amt);
        GameManager.AddRound(r);
    }
}
