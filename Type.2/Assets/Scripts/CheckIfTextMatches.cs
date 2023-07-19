using System;
using TMPro;
using UnityEngine;

public class CheckIfTextMatches : MonoBehaviour
{
    [SerializeField] private TMP_InputField PlayInputField;

    [SerializeField] private TMP_InputField SettingsInputField;

    [SerializeField] private TMP_InputField AboutInputField;

    [SerializeField] private TextMeshProUGUI PlayInputFieldPlaceholder;

    [SerializeField] private TextMeshProUGUI SettingsInputFieldPlaceholder;
    
    [SerializeField] private TextMeshProUGUI AboutInputFieldPlaceholder;
    
    [SerializeField] private PublicAnimations publicAnimations;
    
    public void checkIfTextMatches()
    {
        if (PlayInputField.text == PlayInputFieldPlaceholder.text)
        {
            Debug.Log("Play");
        }
        
        else if (SettingsInputField.text == SettingsInputFieldPlaceholder.text)
        {
            publicAnimations.SettingsAnimation();
        }
        
        else if (AboutInputField.text == AboutInputFieldPlaceholder.text)
        {
            Debug.Log("About");
        }
        else
        {
            //Whatever
        }
    }

    public void CheckMatches(string currentValue)
    {
        if (currentValue.Equals(PlayInputFieldPlaceholder.text, StringComparison.InvariantCultureIgnoreCase))
        {
            Debug.Log("Play");
        }else if (currentValue.Equals(SettingsInputFieldPlaceholder.text, StringComparison.InvariantCultureIgnoreCase))
        {
            publicAnimations.SettingsAnimation();
        }else if (currentValue.Equals(AboutInputFieldPlaceholder.text, StringComparison.InvariantCultureIgnoreCase))
        {
            Debug.Log("About");
        }
    }
}