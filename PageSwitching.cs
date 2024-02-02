using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PageSwitching : MonoBehaviour //PageSwitching Script
{

    public GameObject homePage, panel2, panel3, panel4; //this is page or panel


    public void getIndex(int i)// this fun() get the number and match with case and excute that code.
    {
        switch (i)
        {
            case 1:
                {
                    homePage.SetActive(false);
                    panel2.SetActive(true);
                    break;
                }

            case 2:
                {
                    panel2.SetActive(false);
                    panel3.SetActive(true);
                    break;
                }

            case 3:
                {
                    panel3.SetActive(false);
                    panel4.SetActive(true);
                    break;
                }

            case 4:
                {
                    panel2.SetActive(false);
                    homePage.SetActive(true);
                    break;
                }

            case 5:
                {
                    panel3.SetActive(false);
                    panel2.SetActive(true);
                    break;
                }

            case 6:
                {
                    panel4.SetActive(false);
                    panel3.SetActive(true);
                    break;
                }

            case 7:
                {
                    homePage.SetActive(true);
                    panel2.SetActive(false);
                    panel3.SetActive(false);
                    panel4.SetActive(false);
                    break;
                }
        }
    }

}