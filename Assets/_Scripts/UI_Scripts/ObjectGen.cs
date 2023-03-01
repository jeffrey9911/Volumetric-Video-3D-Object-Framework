using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ObjectGen : MonoBehaviour
{
    public Transform _generator;

    public List<GameObject> scanCaptureObj = new List<GameObject>();

    public TMP_Dropdown dropDownMenu;

    string selectedObjName = "";

    // Start is called before the first frame update
    void Start()
    {
        dropDownMenu.ClearOptions();
        foreach (GameObject obj in scanCaptureObj)
        {
            TMP_Dropdown.OptionData option = new TMP_Dropdown.OptionData(obj.name);
            dropDownMenu.options.Add(option);
        }

        dropDownMenu.onValueChanged.AddListener(OnValueChanged);

    }

    void OnValueChanged(int index)
    {
        selectedObjName = dropDownMenu.options[index].text;
        Debug.Log(selectedObjName + "IS SELECTED!");
    }

    public void GenerateOnClick()
    {
        foreach (GameObject obj in scanCaptureObj)
        {
            if(obj.name == selectedObjName)
            {
                GameObject spawnObj = Instantiate(obj, _generator);
                spawnObj.transform.localPosition = Vector3.zero;
            }
        }
    }
}
