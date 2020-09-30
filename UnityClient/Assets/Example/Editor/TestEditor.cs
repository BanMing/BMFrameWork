using BMBaseCore;
using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

public class TestEditor
{
    [MenuItem("Tools/Test/Delete Empty Directory")]
    private static void RemoveEmptyDirectory()
    {
        Debug.Log(Application.dataPath + "/Test/");
        Utility.File.RemoveEmptyDirectory(Application.dataPath + "/Test/");
        AssetDatabase.Refresh();
    }

    [MenuItem("Tools/Test/String Test")]
    private static void StringTest()
    {
        Debug.Log("adas".ToFirstUpper());
        Debug.Log("Das".ToFirstLower());
    }

    [MenuItem("Tools/Test/Angle Test")]
    private static void AngleTest()
    {
        //Debug.Log("back:" + Utility.Math.AngleBetweenForward2Vector(Vector3.back));
        //Debug.Log("forward" + Utility.Math.AngleBetweenForward2Vector(-Vector3.forward));
        //Debug.Log("left:" + Utility.Math.AngleBetweenForward2Vector(Vector3.left));
        //Debug.Log("right:" + Utility.Math.AngleBetweenForward2Vector(Vector3.right));
        //Debug.Log(Utility.Math.AngleBetweenForward2Vector3(new Vector3(1, 1, 0)));
        //Debug.Log(Vector3.Angle(Vector3.right, Vector3.left));
        //Debug.Log(Utility.Math.GetPoint2LineDis(new Vector3(0, 1, 0), new Vector3(0, 1, 0)));
        //Debug.Log(Utility.Math.GetPoint2LineDis(new Vector3(0, 1, 0), new Vector3(2, 0, 0), new Vector3(2, 1, 0)));
        Debug.Log(Utility.Math.GetIntersectionPoint(new Vector3(0, 1, 0), new Vector3(2, 0, 0), new Vector3(2, 9, 0)));
    }

    [MenuItem("Tools/Test/List Test")]
    private static void ListTest()
    {
        Dictionary<int, bool> dict = new Dictionary<int, bool>();
        dict.Add(1, true);
        dict.Add(2, true);
        dict.Add(4, false);
        dict.Add(5, true);
        dict.Add(7, false);

        List<int> keys = dict.ToKeyList();
        List<bool> values = dict.ToValueList();
        Debug.Log($"keys:{keys.ToItemString()}");
        Debug.Log($"values:{values.ToItemString()}");
    }

}