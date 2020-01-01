using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    private List<int> scores = new List<int>();

    public int id { get; protected set; }
    public int icon_index { get; protected set; }


    public Player(int id, int icon_index) {
        this.id = id;
        this.icon_index = icon_index;
    }
}
