using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]

public class PlayerController : MonoBehaviour
{

    [SerializeField] private SkinManager SkinManager;

    [SerializeField] private InterstitialAdExample interstitialAdExample;

    public Vector3 jump;
    public float jumpForce = 2.2f;

    public bool isGrounded;
    Rigidbody rb;

    [SerializeField]
    public BoxCollider boxCollider;

    public GameManager gameManager;

    public GameObject Coin;
    public int Coins = 0;
    public Text CoinAnzeige;

    public int TotCount = 0;
    private bool ToterCount = false;


    public void Start()
    {
        GetComponent<SpriteRenderer>().sprite = SkinManager.GetSelectedSkin().sprite;

        CoinAnzeige = GameObject.Find("Menu/Coin/CoinText").GetComponent<Text>();

        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);

        CoinAnzeige.text = "Coins: " + Coins;
        Coins = PlayerPrefs.GetInt("Coins", Coins);


    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    public void Update()
    {
        
        GetComponent<SpriteRenderer>().sprite = SkinManager.GetSelectedSkin().sprite;


        CoinAnzeige.text = "Coins: " + Coins;

        if (TotCount == 6 && ToterCount== false)
        {
            Werbung7();
            ToterCount = true;
        }

        if (TotCount == 14 && ToterCount==true)
        {
            Werbung7();
            ToterCount = false;
        }

        if (TotCount == 22&&ToterCount==false)
        {
            Werbung7();
            ToterCount = true;
        }

        if (TotCount == 30&&ToterCount==true)
        {
            Werbung7();
            ToterCount = false;
        }



        PlayerPrefs.SetInt("Coins", Coins);
    }

    void OnTriggerEnter(Collider col)
    {
        if((col.tag == "Obstacel"))
        {
            Destroy(GameObject.FindWithTag("Obstacel"));
            TotCount++;
            gameManager.GameOver();

        }



        if ((col.tag == "Coin"))
        {
            Coins = Coins +1 ;
            Destroy(GameObject.FindWithTag("Coin"));


        }
    }

    public void jumpen()
    {
        if (isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;

        }
    }
    
    public void coinzehn()
    {
        Coins = Coins -10;
    }

    public void coinplusdrei()
    {
        Coins = Coins + 3;
    }

    public void Werbung7()
    {
        interstitialAdExample.ShowAd();
    }
}
