using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Muks.DataBind;

public class TestScene : MonoBehaviour
{
    void Start()
    {
        DataBind.SetTextValue("Test", "Hi");
    }

}
