using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    public TMP_Text scoreText;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(Instance);
        Instance = this;
    }
}
