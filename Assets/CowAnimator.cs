using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowAnimator : MonoBehaviour
{
    public Animator headAnim;

    public Animator tailAnim;

    [SerializeField] List<string> animNames = new List<string>();

    public void HeadSwing(int value)
    {
        headAnim.SetBool("Swing", value != 0);
    }

    public void DEFAULT()
    {
        foreach(string name in animNames)
        {
            headAnim.SetBool(name, false);
        }
    }

    public void DANSE(string name)
    {
        DEFAULT();
        headAnim.SetBool("isDancing", true);
        headAnim.SetBool(name, true);
    }
}
