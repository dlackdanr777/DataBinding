using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Muks.DataBind;

public class TestScene : MonoBehaviour
{
    [SerializeField] private Sprite _sprite;

    void Start()
    {
        DataBind.SetTextValue("Test", "Hi");
        DataBind.SetSpriteValue("Tests", _sprite);
        DataBind.SetUnityActionValue("Test", OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        Debug.Log("Test");
    }
}
