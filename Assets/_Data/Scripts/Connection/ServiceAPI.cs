using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
using System.IO;

public class ServiceAPI : MonoBehaviour
{
    [SerializeField] private TMP_InputField text;
    [SerializeField] private Button registerButton;
    [SerializeField] private TextMeshProUGUI textError;

    private void Awake()
    {
        registerButton.onClick.AddListener(registerNewPlayer);
    }

    void Start()
    {
        CreateFileUpload();
    }

    IEnumerator GetResult()
    {
        UnityWebRequest webRequest = UnityWebRequest.Get("http://localhost/leaderboard/test.php");
        yield return webRequest.SendWebRequest();
        text.text = webRequest.downloadHandler.text;
    }

    public void registerNewPlayer()
    {
        if(text.text == "")
        {
            SetText("Data not empty");
            return;
        }


        StartCoroutine(GetResult());
    }

    public void SetText(string text)
    {
        textError.text = text;
    }

    public void CreateFileUpload()
    {
        
        string writeText = "Hello World!";  // Create a text string
        File.WriteAllText("filename.dat", writeText);  // Create a file and write the content of writeText to it

        string readText = File.ReadAllText("filename.dat");  // Read the contents of the file
        textError.text = readText;
    }

}
