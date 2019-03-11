using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HexadecimalValidation : MonoBehaviour
{
    public string hexadecimalKey;
    public TMP_InputField currentInput;
    public TextMeshProUGUI notificationText;
    public string trueValue;

    public void validateAnswers()
    {
        if (currentInput.text != hexadecimalKey)
        {
            notificationText.text = "ERROR";
            notificationText.color = Color.red;
        }
        else
        {
            notificationText.text = trueValue;
            notificationText.color = Color.green;
        }
    }
}
