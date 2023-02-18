using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;

public class ServiceAPI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    void Start()
    {
        StartCoroutine(GetResult());
    }

    IEnumerator GetResult()
    {
        UnityWebRequest webRequest = UnityWebRequest.Get("http://localhost/leaderboard/test.php");
        yield return webRequest.SendWebRequest();
        text.text = webRequest.downloadHandler.text;
    }

}
