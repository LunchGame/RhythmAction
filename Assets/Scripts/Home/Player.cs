using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int PlayerClass { get; set; }

    public bool isEditMode = false;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
