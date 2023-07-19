using DG.Tweening;
using System.Collections;
using System;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class KeyboardInputManager : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField PlayInputField;

    [SerializeField]
    private TMP_InputField SettingsInputField;

    [SerializeField]
    private TMP_InputField AboutInputField;

    [SerializeField]
 
    private string character;

    private void Start()
    {
       
    }

    private void Update()
    {
        foreach (char c in Input.inputString)
        {
            if (c == '\b') // has backspace/delete been pressed?
            {
                if (PlayInputField.text.Length != 0)
                {
                    PlayInputField.text = PlayInputField.text.Substring(
                        0,
                        PlayInputField.text.Length - 1
                    );
                }
                if (SettingsInputField.text.Length != 0)
                {
                    SettingsInputField.text = SettingsInputField.text.Substring(
                        0,
                        SettingsInputField.text.Length - 1
                    );
                }
                if (AboutInputField.text.Length != 0)
                {
                    AboutInputField.text = AboutInputField.text.Substring(
                        0,
                        AboutInputField.text.Length - 1
                    );
                }
            }
            else if ((c == '\n') || (c == '\r')) // enter/return
            {
                return;
            }
            else
            {
                PlayInputField.text += c;
                SettingsInputField.text += c;
                AboutInputField.text += c;
            }
        }
    }
   
    }


