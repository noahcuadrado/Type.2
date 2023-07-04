using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuAnimation : MonoBehaviour
{
    [SerializeField] private CanvasGroup MainTitle;
    [SerializeField] private CanvasGroup MainMenuContainer;

    [SerializeField] private RectTransform MainTitleContainer;
    [SerializeField] private RawImage Caret;

    private void Start()
    {
        MainTitleAnimation();
    }

    public void MainTitleAnimation()
    {
        Sequence OnGameStart = DOTween.Sequence();
        OnGameStart.Append(MainTitle.DOFade(2f, 1f));
        OnGameStart.Append(MainTitleContainer.DOMoveY(2f, 1f));
        OnGameStart.Append(MainMenuContainer.DOFade(1f, 2f));
        OnGameStart.IsComplete();
        Sequence CaretBlink = DOTween.Sequence();
        CaretBlink.SetLoops(-1);
        CaretBlink.Append(Caret.DOFade(1f, 0.6f));
        CaretBlink.Append(Caret.DOFade(0f, 0.6f));
    }
}