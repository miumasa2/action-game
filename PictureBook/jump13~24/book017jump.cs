using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class book017jump : MonoBehaviour
{
    public void Endoption()
    {
        //メソッドの呼び出し
        StartCoroutine("hyoumonndako");
    }

    IEnumerator hyoumonndako()
    {
        //飛ぶ時の遅延
        yield return new WaitForSeconds(0.0f);
        //オブジェクトの破壊
        Destroy(gameObject);
        //飛ぶシーン名
        SceneManager.LoadScene("hyoumonndako");
        FindObjectOfType<SoundManager>().PlaySeByName("魔王魂 効果音 システム49");
    }
}