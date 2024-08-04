using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Reflection;

public class Menu : MonoBehaviour
{
    bool open = false;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] CanvasGroup canvas;
    [SerializeField] CowAnimator cow;

    public void SwitchMenu()
    {
        open = !open;
        text.text = open ? "X" : "DANCE";
        canvas.alpha = open ? 1 : 0;
        canvas.interactable = open;        
    }

    //public void ChooseDanse(string param)
    //{
    //    TypeInfo cowType = cow.GetType().GetTypeInfo();
    //    var methods = cowType.GetMethods();
    //    foreach ( var method in methods )
    //    {
    //        if( method.Name == param)
    //        {
    //            method.Invoke(cow, null);
    //        }
    //    }
    //}

    public void AnimDanse(string name)
    {
        cow.DANSE(name);
    }
}
