using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    public static UIMgr I;
    public Loading loading;
    public Lvl_01 lvl_01;
    public Lvl_02 lvl_02;
    public Lvl_03 lvl_03;
    public Lvl_04 lvl_04;
    public Lvl_05 lvl_05;
    public Lvl_06 lvl_06;
    public Lvl_07 lvl_07;
    public Lvl_08 lvl_08;
    public Lvl_09 lvl_09;
    public Lvl_10 lvl_10;
    public Lvl_11 lvl_11;

    public VideoPlaying vdPlaying;
    

    void Awake()
    {
        I = this;
        loading.Initiate();
        lvl_01.Initiate();
        lvl_02.Initiate();
        lvl_03.Initiate();
        lvl_04.Initiate();
        lvl_05.Initiate();
        lvl_06.Initiate();
        lvl_07.Initiate();
        lvl_08.Initiate();
        lvl_09.Initiate();
        lvl_10.Initiate();
        lvl_11.Initiate();

        vdPlaying.Init();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
