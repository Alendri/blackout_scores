using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public static class GameManager {
    private static List<Player> players = new List<Player>();
    private static List<Sprite> icons = new List<Sprite>();
    private static List<Round> rounds = new List<Round>();

    public static ReadOnlyCollection<Player> GetPlayers() {
        return new ReadOnlyCollection<Player>(players);
    }
    public static Sprite GetIcon(int index) {
        return icons[index];
    }
    public static int AddIcon(Sprite icon) {
        icons.Add(icon);
        return icons.Count - 1;
    }
    public static void AddPlayer(int icon_index) {
        Player p = new Player(players.Count, icon_index);
        players.Add(p);
        Signals.PlayerAdded(p);
    }
    public static void RemovePlayer(Player p) {
        players.Remove(p);
        Signals.PlayerRemoved();
    }

    public static int GetPlayerIndex(Player p) {
        return players.IndexOf(p);
    }

    public static void ResetRound() {
        rounds = new List<Round>();
    }

    public static int roundCount { get { return rounds.Count; } }
    public static void AddRound(Round r) {
        rounds.Add(r);
    }
    public static Round GetRound(int index = -1) {
        if (index == -1) {
            index = rounds.Count - 1;
        }
        return rounds[index];
    }
    public static ReadOnlyCollection<Round> GetRounds() {
        return new ReadOnlyCollection<Round>(rounds);
    }
}


