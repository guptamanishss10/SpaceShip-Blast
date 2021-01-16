using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerControler : MonoBehaviour
{
    [SerializeField] public float moveSpeed;
    internal static bool left = false;
    internal static bool right = false;
    
    [SerializeField] Text scoreTxt;
    internal int score = 0;
    [SerializeField] ParticleSystem playerbust;
    public AudioClip audioCli;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = ((int)score / 100).ToString();
        score += (int)Time.timeScale;
        transform.Translate(-Vector3.up * Time.deltaTime * moveSpeed);
        if(left && transform.position.x>=-2.5f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        else if (right && transform.position.x <= 2.5f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            moveSpeed = 0;
            playerbust.Play();
            AudioSource.PlayClipAtPoint(audioCli, transform.position, 50f);

            Invoke("ShowAds", 1f);
            Invoke("GameOver", 2f);
        }

    }
    private void GameOver()
    {

        PlayerPrefs.SetInt("CurrentScore",score/100);
        SceneManager.LoadScene(2);
        

    }
    public void ShowAds()
    {
        AdManagers.ShowStandardAd();
    }


    // Start is called before the first frame update

}
