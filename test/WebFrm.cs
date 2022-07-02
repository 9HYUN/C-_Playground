using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class WebFrm : Form
    {

        public string id = string.Empty;
        public string pwd = string.Empty;
        public WebFrm()
        {
            InitializeComponent();
            // 자바스크립트 오류 안뜨게하기
            wbMain.ScriptErrorsSuppressed = true;
        }
        private void WebFrm_Load(object sender, EventArgs e)
        {
            String url = "https://tickets.interpark.com/goods/22006622";
            // wbMain을 url페이지로 이동
            wbMain.Navigate(url);
        }

        private async void btnGo_Click(object sender, EventArgs e)
        {

            //문제점 로그인시 자동방지 시스템 발동
            //자동 로그인 Id 값
            String url = "https://ticket.interpark.com/Gate/TPLogin.asp?GPage=https%3A%2F%2Ftickets.interpark.com%2Fgoods%2F22006622";
            wbMain.Navigate(url);
            await Task.Delay(2500);
            wbMain.Document.GetElementById("userId").SetAttribute("value", "wosmd109");
            await Task.Delay(500);
            wbMain.Document.GetElementById("userPwd").SetAttribute("value", "cjstkWkd!2");
            //await Task.Delay(1500);
            //wbMain.Document.GetElementById("btn_login").InvokeMember("click");
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                // 위에 입력해놓은 함수 불러서 페이지 이동 시키기
                btnGo_Click(sender, e);
            }
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            // wbMain의 페이지 뒤로가기
            wbMain.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            // wbMain의 페이지 앞으로가기
            wbMain.GoForward();
        }

        private void wbMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // form의 상단 Text 변경
            this.Text = wbMain.DocumentTitle;
        }



    }
    public class UserName
    {
        

        public string Id { get; set; }
        public string Pwd { get; set; }





    }
}
