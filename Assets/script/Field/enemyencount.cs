using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyencount : MonoBehaviour
{
    [SerializeField]
    Charmove cmsc;
    AudioChange ac;
    AudioSource audios;


    public AudioClip[] clips;
    int i = 0,encP;
    int encount_num = 9;
    int[] pokemonid = new int[] { 1,4,7};

    void Start(){
        audios = GameObject.Find("FieldAudio").GetComponent<AudioSource>();
        cmsc = GameObject.Find("player").GetComponent<Charmove>();
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player")
        {
            i = UnityEngine.Random.Range(0,100);
            encP = Random.Range(0,3);
            Debug.Log(i);
            if(i <= encount_num) {
                // 出現ポケモン表示

                //ポケモン抽選決定
                SetPokeID(pokemonid[encP]);
                Debug.Log(pokemonid[encP]);

                // シーン遷移
                FadeManager.Instance.LoadScene ("Battle", 1.0f);

                // 音楽止めて戦闘BGM流したい
                // audios.clip = clips[0];
                // audios.Play();

                ac = GameObject.Find("FieldAudio").GetComponent<AudioChange>();
                ac.BattleSound();

                // 動かなくしたい
                cmsc.IsEncount = true;
                cmsc.SetPos();

            }
            else {
                cmsc.IsEncount = false;
            }
        }
    }

    void SetPokeID(int id){
        PlayerPrefs.SetInt("ENCID", id);
        PlayerPrefs.Save();
    }
}
