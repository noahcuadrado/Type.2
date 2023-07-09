using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PublicAnimations : MonoBehaviour
{
    [SerializeField] private CanvasGroup SettingsBG;
    [SerializeField] private CanvasGroup SettingsEmpty;
    public void SettingsAnimation()
    {
        Sequence SettingsAnimation = DOTween.Sequence();
        //SettingsBG.gameObject.SetActive(true);
        SettingsAnimation.Append(SettingsBG.DOFade(0.5f, 10f));
        SettingsAnimation.Append(SettingsEmpty.DOFade(1f, 10f));
        SettingsAnimation.Complete();
    }
}
