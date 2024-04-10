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
        DataBind.SetUnityActionValue("Test", OnButtonClicked1);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Change Func1");
            DataBind.SetUnityActionValue("Test", OnButtonClicked1);
        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Change Func2");
            DataBind.SetUnityActionValue("Test", OnButtonClicked2);
        }
    }


    private void OnButtonClicked1()
    {
        Debug.Log("Button Click Test1");
    }

    private void OnButtonClicked2()
    {
        Debug.Log("Button Click Test2");
    }
}
