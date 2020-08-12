using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Share : MonoBehaviour
{
    string subject = "subject";
    string text = "text";

    public void ShareInSocialMedia()
    {
        StartCoroutine(TakeSSAndShare());
    }

    private IEnumerator TakeSSAndShare()
    {
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();

        string filePath = Path.Combine(Application.temporaryCachePath, "SharedImg.png");
        File.WriteAllBytes(filePath, ss.EncodeToPNG());

        Destroy(ss);

        //new NativeShare().AddFile(filePath).SetSubject(subject).SetText(text).Share();
        new NativeShare().AddFile(filePath).Share();
    }

}
