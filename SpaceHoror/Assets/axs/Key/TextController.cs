using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    private Animation anim;
    public AnimationClip a;
    void Start()
    {
        anim = GetComponent<Animation>();
      
    }
    public void ANM()
    {
        anim.Play(a.name);
    }
}
