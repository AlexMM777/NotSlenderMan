using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public GameObject CimBtn;
    public GameObject EmmBtn;
    public GameObject RnTxt;
    public GameObject EntNam;
    public GameObject FimBtn;
    public GameObject ChngMMServ;
    public GameObject DisMtchMkr;

    public void OpenCIM()
    {
        CimBtn.SetActive(true);
    }
    public void OpenEMM()
    {
        EmmBtn.SetActive(true);
    }
    public void OpenRN()
    {
        RnTxt.SetActive(true);
    }
    public void OpenEntNam()
    {
        EntNam.SetActive(true);
    }
    public void OpenFIM()
    {
        FimBtn.SetActive(true);
    }
    public void OpenCMMS()
    {
        ChngMMServ.SetActive(true);
    }
    public void OpenDMM()
    {
        DisMtchMkr.SetActive(true);
    }



    public void CloseCIM()
    {
        CimBtn.SetActive(false);
    }
    public void CloseEMM()
    {
        EmmBtn.SetActive(false);
    }
    public void CloseRN()
    {
        RnTxt.SetActive(false);
    }
    public void CloseEntNam()
    {
        EntNam.SetActive(false);
    }
    public void CloseFIM()
    {
        FimBtn.SetActive(false);
    }
    public void CloseCMMS()
    {
        ChngMMServ.SetActive(false);
    }
    public void CloseDMM()
    {
        DisMtchMkr.SetActive(false);
    }

}
