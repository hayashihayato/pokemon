using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyencount : MonoBehaviour
{
    GameObject go;
    AudioSource audios;
    bool IsEncount = false;

    public AudioClip[] clips;
    int i = 0;
    int encount_num = 9;
    string[] pokemon = new string[] {
        "ポッポ",
        "ポッポ",
        "ポッポ",
        "ポッポ",
        "ポッポ",
        "コラッタ",
        "コラッタ",
        "コラッタ",
        "コラッタ",
        "ピカチュウ" };

    void Start()
    {
        go = GameObject.Find("FieldAudio");

        audios = go.GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            i = UnityEngine.Random.Range(0,100);
            Debug.Log(i);
            if(i <= encount_num) {
                // 出現ポケモン表示
                Debug.Log(pokemon[i]);
                // シーン遷移
                FadeManager.Instance.LoadScene ("Battle", 1.0f);

                // 音楽止めて戦闘BGM流したい
                audios.clip = clips[0];
                audios.Play();

                // 動かなくしたい
                IsEncount = true;


            }
            else {
                Debug.Log("出現なし");
                IsEncount = false;
            }
        }
    }
}
