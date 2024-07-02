using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject toolbarpanel;

    private void Update() //kullan�c� paneli � ile a�s�n
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            panel.SetActive(!panel.activeInHierarchy);
            toolbarpanel.SetActive(!toolbarpanel.activeInHierarchy);
        }
    }
}
