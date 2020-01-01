using System.Collections.Generic;
using UnityEngine;

public static class GameManager {
    private static List<Player> players = new List<Player>();
    private static List<Sprite> icons = new List<Sprite>();

    public static List<Player> GetPlayers() {
        return players;
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
}


