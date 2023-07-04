using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnimation : MonoBehaviour
{
    [SerializeField] private Animator MainScreenAnimator;

    void Start()
    {
        MainScreenAnimator.SetBool("Start", true);
        if (MainScreenAnimator.GetCurrentAnimatorStateInfo(0).IsName("MainTitleFadeIn"))
        {
            MainScreenAnimator.SetBool("Start", false);
            MainScreenAnimator.SetBool("isCompleted", true);
        }
    }

    private void Update()
    {
       
    }

}
