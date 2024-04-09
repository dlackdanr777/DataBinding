using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace Muks.DataBind
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TextMeshProGetter : MonoBehaviour
    {
        [SerializeField] private string _bindId;

        private BindData<string> _data;
        private TextMeshProUGUI _text;


        private void Awake()
        {
            if (string.IsNullOrEmpty(_bindId))
            {
                Debug.LogErrorFormat("Invalid text data ID. {0}", gameObject.name);
                enabled = false;
            }

            _text = GetComponent<TextMeshProUGUI>();
            _data = DataBind.GetTextBindData(_bindId);
            _data.CallBack += UpdateText;

        }


        private void OnEnable()
        {
            _text.text = _data.Item;
        }


        private void UpdateText(string text)
        {
            if (enabled)
                _text.text = text;
        }


        private void OnDestroy()
        {
            if (_data == null)
                return;

            _data.CallBack -= UpdateText;
        }
    }
}

