using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberInput : MonoBehaviour {
    public int max = 99;
    public int min = 1;
    public Button okBtn;
    public Button eraseBtn;
    public TextMeshProUGUI text;
    private string display = "1";
    private int value = 1;

    void Start() {
        text.SetText(display);
        // okBtn.onClick.AddListener()
        eraseBtn.onClick.AddListener(Erase);
    }

    public void Add(string digit) {
        int new_val;
        if (int.TryParse(display += digit, out new_val)) {
            display += digit;
            UpdateUI(new_val);
            value = new_val;
        }
    }

    public void Erase() {
        //Remove last digit from string.
        if (display.Length > 1) {
            display = display.Substring(0, display.Length - 1);
            int new_val;
            if (int.TryParse(display, out new_val)) {
                UpdateUI(new_val);
                value = new_val;
            } else {
                UpdateUI();
            }
        }
    }

    private void UpdateUI(int val = int.MinValue) {
        if (display.Length > 0) {
            eraseBtn.interactable = true;
        } else {
            eraseBtn.interactable = false;
        }

        if (val <= max && val >= min) {
            okBtn.interactable = true;
        } else {
            okBtn.interactable = false;
        }
        text.SetText(display);
    }
}
