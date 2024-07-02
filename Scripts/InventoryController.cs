using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject toolbarpanel;

    private void Update() //kullanýcý paneli ý ile açsýn
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            panel.SetActive(!panel.activeInHierarchy);
            toolbarpanel.SetActive(!toolbarpanel.activeInHierarchy);
        }
    }
}
