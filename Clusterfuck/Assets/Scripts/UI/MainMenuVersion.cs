using TMPro;
using UnityEngine;

namespace UI
{
    public class MainMenuVersion : MonoBehaviour
    {
        [SerializeField] private TMP_Text versionText;

        private void Start()
        {
            versionText.text = $"Version: {GameManager.Instance.gameVersion}";
        }
    }
}
