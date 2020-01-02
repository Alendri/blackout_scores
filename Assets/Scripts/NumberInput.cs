using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberInput : MonoBehaviour {

    public Button okBtn;
    public Button eraseBtn;
    public Button increaseBtn;
    public Button decreaseBtn;
    public TextMeshProUGUI text;
    public TextMeshProUGUI minValueText;
    public TextMeshProUGUI maxValueText;

    private Action<int> cb;
    private string display = "1";
    private int value = 1;
    private int max = 99;
    private int min = 1;

    void Start() {
        text.SetText(display);
        okBtn.onClick.AddListener(Finish);
        eraseBtn.onClick.AddListener(Erase);
        increaseBtn.onClick.AddListener(Increase);
        decreaseBtn.onClick.AddListener(Decrease);
        // gameObject.SetActive(false);
    }
    void OnDestroy() {
        eraseBtn.onClick.RemoveAllListeners();
        okBtn.onClick.RemoveAllListeners();
        increaseBtn.onClick.RemoveAllListeners();
        decreaseBtn.onClick.RemoveAllListeners();
    }

    public void Init(int min, int max, Action<int> cb) {
        this.min = min;
        this.max = max;
        this.cb = cb;
        minValueText.SetText(min.ToString());
        maxValueText.SetText(max.ToString());
        gameObject.SetActive(true);
    }

    public void Add(string digit) {
        if (display.Length >= 3) {
            return;
        }
        int new_val;
        if (int.TryParse(display + digit, out new_val)) {
            display += digit;
            value = new_val;
            UpdateUI();
        }
    }

    public void Erase() {
        //If length permits remove last digit from string.
        if (display.Length > 0) {
            display = display.Substring(0, display.Length - 1);
            int new_val;
            if (int.TryParse(display, out new_val)) {
                //If parse is valid update the value of this input. And update UI.
                value = new_val;
                UpdateUI();
            } else {
                //Otherwise only update UI.
                value = 0;
                UpdateUI();
            }
        }
    }

    private void Finish() {
        if (cb == null) {
            throw new Exception("No Callback defined for NumberInput. Value: " + value);
        }
        cb(value);
    }
    private void UpdateUI() {
        if (display.Length > 0) {
            eraseBtn.interactable = true;
        } else {
            eraseBtn.interactable = false;
        }

        if (value <= max && value >= min) {
            okBtn.interactable = true;
        } else {
            okBtn.interactable = false;
        }
        text.SetText(display);
    }

    private void Increase() {
        if (value < max) {
            value += 1;
        } else {
            value = max;
        }
        text.SetText(value.ToString());
        display = value.ToString();
        UpdateUI();
    }
    private void Decrease() {
        if (value > min) {
            value -= 1;
        } else {
            value = min;
        }
        text.SetText(value.ToString());
        display = value.ToString();
        UpdateUI();
    }
}
