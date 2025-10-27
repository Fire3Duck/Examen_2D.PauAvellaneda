using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public static Game_Manager instance { get; private set; }
    int _stars = 0;
    [SerializeField] public InputActionAsset playerInputs;

    public bool isPlaying = true;

    public Text starText;

    void Start()
    {
        starText.text = _stars.ToString();
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);

        starText.text = _stars.ToString();
        
    }

    public void AddStar()
    {
        _stars++;
        Debug.Log("Stars: " + _stars);
        starText.text = _stars.ToString();
    }
}
