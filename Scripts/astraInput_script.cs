using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astraInput_script : MonoBehaviour
{
    Animator astraAnimator;
    float verticalPress;
    void Start()
    {
        astraAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        verticalPress = Input.GetAxis("Vertical");
        astraAnimator.SetFloat("Blend", verticalPress);
    }
}
