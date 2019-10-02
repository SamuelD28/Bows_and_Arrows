using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;

    private void OnMouseDown()
    {
        OpenPanel();
    }

    public void OpenPanel()
    {
        if (!Panel.activeSelf)
        {
            Panel.SetActive(true);
        }
        else

            Panel.SetActive(false);
    }
}
