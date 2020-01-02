using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAmountPanel : MonoBehaviour {
    public GameObject numberInputPrefab;
    private GameObject numberInput;
    public void Show(Action<int> cb) {
        if (numberInput) {
            Destroy(numberInput);
        }
        numberInput = Instantiate(numberInputPrefab, gameObject.transform);
        int players = GameManager.GetPlayers().Count;
        int max = (int)Math.Floor(51f / players);
        numberInput.GetComponent<NumberInput>().Init(1, max, card_amt => {
            cb(card_amt);
            Destroy(numberInput);
            gameObject.SetActive(false);
        });
        gameObject.SetActive(true);
    }
}
