using TMPro;
using UnityEngine;

public class CheckIfTextMatches : MonoBehaviour {
    [SerializeField]
    private TMP_InputField PlayInputField;

    [SerializeField]
    private TMP_InputField SettingsInputField;

    [SerializeField]
    private TMP_InputField AboutInputField;

    [SerializeField]
    private TextMeshProUGUI PlayInputFieldPlaceholder;

    [SerializeField]
    private TextMeshProUGUI SettingsInputFieldPlaceholder;
    [SerializeField]
    private PublicAnimations publicAnimations;

    [SerializeField]
    private TextMeshProUGUI AboutInputFieldPlaceholder;
     public void checkIfTextMatches(){
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
     }
}