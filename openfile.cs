using UnityEngine;
using System.Collections;
using System.IO;
using System.Diagnostics;

public class openfile : MonoBehaviour 
{
    //string paths = @"E:\WinToDog\Titles.EXE";
  
        void Awake()
    {
            File.CreateText(Application.streamingAssetsPath + @"\Invalidcode.txt");
    }
    
    void Start()
    {
        string paths = Application.streamingAssetsPath + @"\ConsoleApplication1.exe";
        Application.OpenURL(paths);
        StartCoroutine(OpenF());
    }


    IEnumerator OpenF() {
        string thefliepaths = Application.streamingAssetsPath + @"\Invalidcode.txt";
        yield return new WaitForSeconds(1f);
        if (ReadFilesto() == "0x000000")
            File.WriteAllText(thefliepaths, "运行没有错误");
        else
        {
            StopAllCoroutines();
            Application.Quit();
        }
    }

    private string  ReadFilesto()
    {
        string thefliepaths = Application.streamingAssetsPath + @"\Invalidcode.txt";
        string t=File.ReadAllText(thefliepaths);
        return t;
    }
    
}

