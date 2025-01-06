using UnityEngine;
using UnityEngine.UI; // Untuk UI Button

public class ButtonController : MonoBehaviour
{
    public Button jumpButton; // Referensi ke tombol lompat
    public Button[] arrowButtons; // Referensi ke tombol panah (4 tombol)
    private bool isArrowClicked = false; // Status tombol panah sudah ditekan

    void Start()
    {
        // Pastikan tombol lompat tidak aktif di awal
        jumpButton.interactable = false;

        // Tambahkan listener untuk setiap tombol panah
        foreach (Button arrowButton in arrowButtons)
        {
            arrowButton.onClick.AddListener(OnArrowClick);
        }

        jumpButton.onClick.AddListener(OnJumpClick);
    }

    public void OnArrowClick()
    {
        // Aktifkan tombol lompat ketika salah satu panah ditekan
        if (!isArrowClicked)
        {
            isArrowClicked = true;
            jumpButton.interactable = true;
            Debug.Log("Salah satu tombol panah ditekan. Tombol lompat aktif.");
        }
    }

    public void OnJumpClick()
    {
        // Periksa apakah salah satu tombol panah sudah ditekan
        if (isArrowClicked)
        {
            Debug.Log("Tombol Lompat ditekan!");
            jumpButton.interactable = false; // Nonaktifkan tombol lompat setelah ditekan
            isArrowClicked = false; // Reset status tombol panah
            // Masukkan logika lompat di sini jika perlu
        }
        else
        {
            Debug.Log("Tombol Lompat belum dapat digunakan!");
        }
    }
}
