using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using System.Globalization;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip goodSpeak;
    public AudioClip normalSpeak;

    public AudioClip badSpeak;

    private AudioSource selectAudio;
    private Dictionary<string, double> dataSet = new Dictionary<string, double>();
    private bool statusStart = false;
    private int i = 0;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoogleSheets());
    }

    // Update is called once per frame
    void Update()
    {
        if (statusStart == false & i != dataSet.Count && dataSet["Loss_" + i.ToString()] <= 500 )
        {
            StartCoroutine(PlaySelectedaudioGood());
            Debug.Log(dataSet["Loss_" + i.ToString()]);
        }

        if (statusStart == false & i != dataSet.Count && dataSet["Loss_" + i.ToString()] > 500 && dataSet["Loss_" + i.ToString()] < 1500)
        {
            StartCoroutine(PlaySelectedaudioNormal());
            Debug.Log(dataSet["Loss_" + i.ToString()]);
        }

        if (statusStart == false & i != dataSet.Count && dataSet["Loss_" + i.ToString()] >= 1500 )
        {
            StartCoroutine(PlaySelectedaudioBad());
            Debug.Log(dataSet["Loss_" + i.ToString()]);
        }
    }

    IEnumerator GoogleSheets()
    {
        UnityWebRequest currentResp = UnityWebRequest.Get("https://sheets.googleapis.com/v4/spreadsheets/1HrVrmJtqHRa16xfqWnv12bGU8CdhN1twQ1R16G31GYI/values/Лист1?key=AIzaSyCmw8tf-nsGdwjfUek97s7olY4iADD1l3A");
        yield return currentResp.SendWebRequest();
        string rawResp = currentResp.downloadHandler.text;
        var rawJson = JSON.Parse(rawResp);
        for (var i = 0;i < rawJson["values"].Count;i++)
        {
            var item = rawJson["values"][i];
            var parseJson = JSON.Parse(item.ToString());
            var selectedRow = parseJson.AsStringList;
            var value = selectedRow[2];
            var loss = double.Parse(value, CultureInfo.InvariantCulture);
            dataSet.Add("Loss_" + i.ToString(), loss);
        }
    }

    IEnumerator PlaySelectedaudioGood()
    {
        statusStart = true;
        selectAudio = GetComponent<AudioSource>();
        selectAudio.clip = goodSpeak;
        selectAudio.Play();
        yield return new WaitForSeconds(3);
        statusStart = false;
        i++;
    }

    IEnumerator PlaySelectedaudioNormal()
    {
        statusStart = true;
        selectAudio = GetComponent<AudioSource>();
        selectAudio.clip = normalSpeak;
        selectAudio.Play();
        yield return new WaitForSeconds(4);
        statusStart = false;
        i++;
    }

    IEnumerator PlaySelectedaudioBad()
    {
        statusStart = true;
        selectAudio = GetComponent<AudioSource>();
        selectAudio.clip = badSpeak;
        selectAudio.Play();
        yield return new WaitForSeconds(2);
        statusStart = false;
        i++;
    }
}

