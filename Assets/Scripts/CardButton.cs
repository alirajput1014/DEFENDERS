using UnityEngine;
using UnityEngine.UI;

public class CardButton : MonoBehaviour
{
    public GameObject playerPrefab;
    private Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (GameManager.Instance != null)
            GameManager.Instance.SelectPlayer(playerPrefab);
    }
}
