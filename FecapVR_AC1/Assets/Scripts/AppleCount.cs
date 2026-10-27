using UnityEngine;

public class AppleCount : MonoBehaviour
{
    public static int appleCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Maca"))
        {
            appleCount++;
            Menu.AppleUI(appleCount);
            Destroy(collision.gameObject);
        }
        if (appleCount < 5) return;
        Menu.WinScreen();
    }
}
