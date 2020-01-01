using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberInputBtn : MonoBehaviour {
    private NumberInput parent;
    private string digit;
    private Button btn;
    void Awake() {
        parent = GetComponentInParent<NumberInput>();
        digit = GetComponentInChildren<TextMeshProUGUI>().text;
        btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    void OnDestroy() {
        btn.onClick.RemoveAllListeners();
    }

    public void OnClick() {
        if (parent && digit.Length > 0) {
            parent.Add(digit);
        } else {
            throw new System.Exception("Uninitialized NumberInputButton.");
        }
    }
}
