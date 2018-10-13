using System.Collections;
using UnityEngine;

public class GameUtility {

    /// <summary>
    /// 获取子节点
    /// </summary>
    /// <returns></returns>
    public static Transform GetChild(GameObject root, string path) {
        Transform tra = root.transform.Find(path);
        if (tra = null) Debug.Log(path + "not find");
        return tra;
    }
    public static T GetChildComponent<T>(GameObject root, string path) where T : Component {
        Transform tra = root.transform.Find(path);
        if (tra == null) Debug.Log(path + "not find");
        T t = tra.GetComponent<T>();
        return t;
    }

}
