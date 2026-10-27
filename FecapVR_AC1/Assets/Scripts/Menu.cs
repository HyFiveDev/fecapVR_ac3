using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{

  [SerializeField] private TextMeshProUGUI appleRef;
  private static TextMeshProUGUI appleText;
  private static GameObject deathPanel;

    private void Awake()
    {
        deathPanel = GameObject.Find("morte");
        deathPanel.SetActive(false);
        appleText = appleRef;
    }

    public static void WinScreen()
    {
   
    }

    public static void AppleUI(int count)
    {
        appleText.text = "Maçãs coletdas:" + count.ToString();

    }

    public static void Death()
    {
        deathPanel.SetActive(true);
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}
