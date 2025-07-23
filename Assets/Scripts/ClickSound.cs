using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ClickSound : MonoBehaviour
{
    public AudioSource clickSoundNewGame;
    public GameObject loading;
    public GameObject lv_01;
    public Button BtnNewGame;
    public CanvasGroup loadingScreen;
    public CanvasGroup lv_01_Screen;
    public float soundDelay = 1f;
    public bool isclicked = false;
    // Start is called before the first frame update
    void Start()
    {
        loading.SetActive(true);
        lv_01.SetActive(false);
        BtnNewGame.onClick.AddListener(OnStartClick);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnStartClick()
    {
        if (isclicked)return;
        isclicked = true;
        clickSoundNewGame.PlayOneShot(clickSoundNewGame.clip);
        BtnNewGame.interactable = false;



        DOVirtual.DelayedCall(soundDelay, () =>
        {
            // �������ж���
            Sequence transitionSequence = DOTween.Sequence();

            // ��ʼ���浭��
            transitionSequence.Append(loadingScreen.DOFade(0, 2f)
                .OnComplete(() => loadingScreen.gameObject.SetActive(false)));

            UIMgr.I.vdPlaying.PlayVideo();

            // ��һ�ص���
            lv_01_Screen.gameObject.SetActive(true);
            transitionSequence.Append(lv_01_Screen.DOFade(1, 2f));


        });
    }
    //loadingScreen.DOFade(0, 2.3f).OnComplete(() =>
    //{
    //    loadingScreen.gameObject.SetActive(false);

    //    lv_01_Screen.gameObject.SetActive(true);
    //    lv_01_Screen.DOFade(1, 2f);
    //});
    void OnDestroy()
    {
        DOTween.KillAll();
    }
}
    