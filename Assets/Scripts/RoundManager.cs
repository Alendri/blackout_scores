using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour {
    public CardAmountPanel cardAmountPanel;
    public void StartRound() {
        gameObject.SetActive(true);
        cardAmountPanel.Show(card_amt => Debug.Log("card amt: " + card_amt));
    }
}
