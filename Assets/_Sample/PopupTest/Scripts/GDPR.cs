using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySample
{
    /// <summary>
    /// ���� ���� ���� â: ����, ���, �������� ������ ��ũ
    /// </summary>
    public class GDPR : Popup
    {
        //���� ���� ����
        public void OnUserClickAccept()
        {
            //���� ���� ���� ����
            Close();
        }

        //���� ���� ���� â ���
        public void OnUserClickCancel()
        {
            //���� ���� �ź� ����
            Close();
        }

        //���� ���� ���� ���ͳ� ������ ����
        public void OnUserClickPrivacyPolicy()
        {
            //Application.OpenURL("home_page_url");
        }
    }
}
