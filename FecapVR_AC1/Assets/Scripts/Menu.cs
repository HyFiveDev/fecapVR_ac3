using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnNavegarClick(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
    void Start()
    
{
        
    }

    void Update()
    {
        
    }
}
