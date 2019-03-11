using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Validation : MonoBehaviour
{
    public TMP_InputField fieldA;
    public TMP_InputField fieldB;
    public TMP_InputField fieldC;
    public TMP_InputField fieldD;
    public TMP_InputField fieldE;
    public TMP_InputField fieldF;
    public TMP_InputField fieldG;
    public TMP_InputField fieldH;
    public TMP_InputField fieldI;
    public TMP_InputField fieldJ;
    public VectorValue startingPosition;
    public Vector2 playerPosition;

    public void EnterButtonValidate()
    {
        if(fieldA.text == "55" && fieldB.text == "52" && fieldC.text == "53" && fieldD.text == "41" && fieldE.text == "20" && fieldF.text == "4D" && fieldG.text == "41" && fieldH.text == "4A" && fieldI.text == "4F" && fieldJ.text == "52")
        {
            startingPosition.initValue = playerPosition;
            SceneManager.LoadScene("UrsaMajor");
        }
    }

}
