using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySample
{
    public class MainMenu : MonoBehaviour
    {
        #region Variables
        public CustomButton settingButton;
        #endregion

        private void Start()
        {
            //��ư �̺�Ʈ�� �Լ� ���
            settingButton.onClick.AddListener(SettingButtonClicked);
        }

        //�ɼ� ��ư Ŭ����
        private void SettingButtonClicked()
        {
            MenuManager.Instance.ShowPopup<Settings>();
        }
    }
}
