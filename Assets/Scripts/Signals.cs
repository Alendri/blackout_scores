using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Signals {
    public delegate void PlayerAddedCB(Player p);
    public static event PlayerAddedCB onPlayerAdded;
    public static void PlayerAdded(Player p) {
        if (onPlayerAdded != null) {
            onPlayerAdded(p);
        }
    }
    public delegate void PlayerRemovedCB();
    public static event PlayerRemovedCB onPlayerRemoved;
    public static void PlayerRemoved() {
        if (onPlayerRemoved != null) {
            onPlayerRemoved();
        }
    }
}
