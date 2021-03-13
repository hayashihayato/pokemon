using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyencount : MonoBehaviour
{
    [SerializeField]
    charmove cmsc;
    GameObject go;
    AudioSource audios;

    public AudioClip[] clips;
    int i = 0,encP;
    int encount_num = 9;
    int[] pokemonid = new int[] { 483, 484, 487 };
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

        cmsc = GameObject.Find("player").GetComponent<charmove>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            i = UnityEngine.Random.Range(0,100);
            encP = Random.Range(0,2);
            Debug.Log(i);
            if(i <= encount_num) {
                // 出現ポケモン表示
                //Debug.Log(pokemon[i]);

                //ポケモン抽選決定
                SetPokeID(pokemonid[encP]);
                Debug.Log(pokemonid[encP]);

                // シーン遷移
                FadeManager.Instance.LoadScene ("Battle", 1.0f);

                // 音楽止めて戦闘BGM流したい
                audios.clip = clips[0];
                audios.Play();

                // 動かなくしたい
                cmsc.IsEncount = true;

            }
            else {
                //Debug.Log("出現なし");
                cmsc.IsEncount = false;
            }
        }
    }

    void SetPokeID(int id)
    {
        PlayerPrefs.SetInt("SCORE", id);
        PlayerPrefs.Save();
    }
}
