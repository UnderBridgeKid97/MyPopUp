using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySample
{
    /// <summary>
    /// �ɼ�â
    /// </summary>
    public class Settings : Popup
    {
        #region Variables
        [SerializeField] private CustomButton back;     //�������� â ����
        [SerializeField] private CustomButton privacy;    //�������� ���� â ����
        #endregion

        private void OnEnable()
        {
            //�ɼ�â ��ư Ŭ���� ȣ��Ǵ� �Լ� ���
            back.onClick.AddListener(BackToMain);
            privacy.onClick.AddListener(PrivacyPolicy);
        }

        private void BackToMain()
        {
            StopInteraction();
            Close();

            //�������� â ����
            MenuManager.Instance.ShowPopup<ExitGame>();
        }

        private void PrivacyPolicy()
        {
            StopInteraction();
            Close();

            //�������� ���� â ����
            MenuManager.Instance.ShowPopup<GDPR>();
        }
    }
}
