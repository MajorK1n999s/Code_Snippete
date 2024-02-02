using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBGchange : MonoBehaviour
{
    public Sprite UnSelectedImg, SelectedImg;
    public Image hospital, trainStaion, mall, salesCenter;

    public void Hospital()
    {
        hospital.sprite = SelectedImg;
        trainStaion.sprite = UnSelectedImg;
        mall.sprite = UnSelectedImg;
        salesCenter.sprite = UnSelectedImg;
    }

    public void TrainStation()
    {
        trainStaion.sprite = SelectedImg;
        hospital.sprite = UnSelectedImg;
        mall.sprite = UnSelectedImg;
        salesCenter.sprite = UnSelectedImg;
    }

    public void Mall()
    {
        mall.sprite = SelectedImg;
        trainStaion.sprite = UnSelectedImg;
        hospital.sprite = UnSelectedImg;
        salesCenter.sprite = UnSelectedImg;
    }

    public void SalesCenter()
    {
        salesCenter.sprite = SelectedImg;
        mall.sprite = UnSelectedImg;
        trainStaion.sprite = UnSelectedImg;
        hospital.sprite = UnSelectedImg;
    }

    public void resetImg()
    {
        salesCenter.sprite = UnSelectedImg;
        mall.sprite = UnSelectedImg;
        trainStaion.sprite = UnSelectedImg;
        hospital.sprite = UnSelectedImg;
    }
}
