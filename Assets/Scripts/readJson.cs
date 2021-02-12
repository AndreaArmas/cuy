using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class readJson : MonoBehaviour
{
    public string jsonUrl;
    public  TextMeshProUGUI information;

    public void getCharacter(int index)
    {
        StartCoroutine(getData(index));
    }

    IEnumerator getData(int index)
    {
        WWW _www = new WWW(jsonUrl);
        yield return _www;

        if(_www.error == null)
        {
            RootObject myObject = JsonUtility.FromJson<RootObject>("{\"characters\":" + _www.text + "}");

            information.text = myObject.characters[index].ToString();
            Debug.Log(myObject.characters[index]);

        }
        else
        {
            Debug.Log("Error");
        }
    }
}

