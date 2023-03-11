using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            anim.SetBool("isAction",true);
        }
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            anim.SetBool("isAction",false);
        }
        
    }
}
