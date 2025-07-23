using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Button btn_NewGame;


    public RectTransform bg_Title;
    public CanvasGroup textTMP;
    public CanvasGroup newGame;
    public CanvasGroup loadGame;
    public CanvasGroup option;
    public CanvasGroup exit;

    public void Initiate() 
    {
        
        Show();
        AnimShow();
        //Lambda Expression: base structure is (()=>{ })
        btn_NewGame.onClick.AddListener(()=>
        {
            Hide();
            UIMgr.I.lvl_01.Show();
        });
    }
    public void Show() { this.gameObject.SetActive(true); }

    public void AnimShow()
    {
        DOTween.Sequence()
               .AppendInterval(1f)
               .Append(bg_Title.DOScaleX(1, 1f))
               .Append(textTMP.DOFade(1, 1f))
               .Join(newGame.DOFade(1, 1f))
               .Join(loadGame.DOFade(1, 1f))
               .Join(option.DOFade(1, 1f))
               .Join(exit.DOFade(1, 1f));
    }

    public void Hide() { this.gameObject.SetActive(false); }
   
    // Start is called before the first frame update
    void Start()
    {

        
    }


    // Update is called once per frame
    void Update()
    {


    }
}
   