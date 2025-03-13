using UnityEngine;

public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string str= "";
        str = System.String.Empty;
        str = "Abc Def Fed Cba";

        Debug.Log(str);
        Debug.Log(str.Length);
        Debug.Log(str[5]);
        Debug.Log(str.ToLower());
        Debug.Log(str.ToUpper());

        Debug.Log(str.Trim());
        Debug.Log(str.TrimStart());
        Debug.Log(str.TrimEnd());

        Debug.Log(str.IndexOf('e'));
        Debug.Log(str.Substring(5, 3));
        Debug.Log(str.Substring(5));
        Debug.Log(str.Remove(5, 3));

        //Debug.Log(str[1] == str[15]);
        Debug.Log("ABC".Equals("Abc"));
        Debug.Log(System.String.Compare("BAC", "Bac"));

        var hi1 = "¾È³ç";
        var hi2 = "ÇÏ¼¼¿ä";

        Debug.Log(hi1 + hi2);
        Debug.Log($"{hi1}{hi2}");
        Debug.Log(System.String.Format("{0},{1}", hi1, hi2));

        Debug.Log(System.String.Format("{0:C}", 1000));
        Debug.Log(System.String.Format("{0:#,###}", 10000000));

        string[] strArray = str.Trim().Split(' ');
        string strAll = "";
        foreach (var s in strArray)
        {
            //Debug.Log(s);
            strAll = strAll + s;
        }
        Debug.Log(strAll);
    }

}
