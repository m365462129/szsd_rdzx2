using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Vuforia;

public class AutoSettingVuforia
{

    [MenuItem("Tools/自动设置Vuforia")]
    public static void DDD()
    {
        bool bbb1 =  EditorApplication.ExecuteMenuItem("GameObject/Vuforia/AR Camera");
        bool bbb2 = EditorApplication.ExecuteMenuItem("GameObject/Vuforia/Image");

        GameObject ImageTarget = GameObject.Find("ImageTarget");
        ImageTarget.transform.SetParent(null);

        VuforiaBehaviour vuforiaBehaviour = GameObject.Find("ARCamera").GetComponent<VuforiaBehaviour>();

    }


}
