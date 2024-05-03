//using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//[RequireComponent(typeof(TextMeshProUGUI))]
public class LevelText : MonoBehaviour
{
    private void Awake()
    {
        var scene = SceneManager.GetActiveScene().buildIndex - 1;
        var text = $"关卡 {scene}";
        var tmp = GetComponent<Text>();
        tmp.text = text;
    }
}