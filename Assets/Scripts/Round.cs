using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class Round {
    public int cardAmount { get; protected set; }
    private Dictionary<Player, int> betsByPlayer;
    private Dictionary<Player, int> scoresByPlayer;

    public ReadOnlyDictionary<Player, int> bets {
        get {
            return new ReadOnlyDictionary<Player, int>(betsByPlayer);
        }
    }
    public ReadOnlyDictionary<Player, int> scores {
        get {
            return new ReadOnlyDictionary<Player, int>(scoresByPlayer);
        }
    }

    public void SetScore(Player p, int s) {
        scoresByPlayer[p] = s;
    }
    public void SetBet(Player p, int b) {
        betsByPlayer[p] = b;
    }

    public Round(int card_amt) {
        cardAmount = card_amt;
        betsByPlayer = new Dictionary<Player, int>();
        scoresByPlayer = new Dictionary<Player, int>();
        foreach (Player p in GameManager.GetPlayers()) {
            betsByPlayer[p] = 0;
            scoresByPlayer[p] = 0;
        };
    }
}
