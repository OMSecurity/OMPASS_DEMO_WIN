using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using OmpassAgent.Helper;

namespace OmpassAgentDemo
{
    enum AuthType
    {
        U2F = 0,
        UAF = 1
    }

    public partial class Form1 : Form
    {
        // #1 : Declare an OMPASS agent
        OmpassLib.OmpassAgent agent;
        AuthType _authType;

        public Form1()
        {
            InitializeComponent();
            InitializeAsync();
        }

        async void InitializeAsync()
        {
            // #2 : Register a webview completion handler of initialization
            webView.CoreWebView2InitializationCompleted += WebView_CoreWebView2Ready;
            // #3 : Await the webview initialization
            await webView.EnsureCoreWebView2Async(null);

            webView.Hide();
            pictureBox1.Show();
            rb_u2f.Checked = true;            

            SetAuthType(AuthType.U2F);
            tb_lang.Text = "EN";
        }       

        // #4 : Complete the webview initialization
        private void WebView_CoreWebView2Ready(object sender, EventArgs e)
        {
            // #5 : Send webview to OmpassLib
            agent = new OmpassLib.OmpassAgent(webView, CallbackLogin);            
            UpdateState("");
            Utility.Log("WebView_CoreWebView2Ready", "Done");
        }

        // #6 : Declare a callback function
        public void CallbackLogin(string data)
        {
            Console.WriteLine("{0}", data);

            webView.Hide();
            pictureBox1.Show();
            UpdateState(GetResult(data));
        }

        string GetResult(string state)
        {
            webView.Hide();
            pictureBox1.Hide();

            string[] results = state.Split(':');
            if (results.Count() < 2)
                return state;

            string result = results[0].Contains("auth") ? "auth" : "register";

            if (results[1].Contains("cancel"))
            {
                result += " was ";
                result += "canceled.";
            }
            else
            {
                result += " was ";
                result += results[1].Contains("success") ? "successed." : "failed.";
            }
            
            return result;
        }            
 

        private void registerBtn_Click(object sender, EventArgs e)
        {
            UpdateState("");
            pictureBox1.Hide();
            webView.Show();

            string url_string = tb_url.Text + ((_authType == AuthType.UAF) ? "/auth/login/uaf" : "/auth/login/u2f");

            // #7 : ompass Login API
            string ret = agent.Login(
                url_string,
                tb_id.Text,
                tb_pass.Text,
                tb_lang.Text);

            Utility.Log("Result", ret);
            if (!ret.Contains("success"))
                UpdateState("ERROR : " + ret);
        }

        void SetAuthType(AuthType type)
        {
            _authType = type;
            UpdateState("");

            tb_url.Text = "https://192.168.182.77:9500";
            //tb_url.Text = "login server url (Relying Party Server)";

            tb_id.Text = "id";
            tb_pass.Text = "password";
            tb_lang.Text = "EN";
            tb_id.Show();
            tb_pass.Show();
            label_id.Show();
            label_pass.Show();

            if (type == AuthType.UAF)
            {
                tb_id.Text = "";
                tb_pass.Text = "";
                tb_id.Hide();
                tb_pass.Hide();
                label_id.Hide();
                label_pass.Hide();
            }
            else
            {
                tb_id.Text = "id";
                tb_pass.Text = "password";
                tb_id.Show();
                tb_pass.Show();
                label_id.Show();
                label_pass.Show();
            }
        }

        private void rb_u2f_CheckedChanged(object sender, EventArgs e)
        {
            SetAuthType(AuthType.U2F);
        }

        private void rb_uaf_CheckedChanged(object sender, EventArgs e)
        {
            SetAuthType(AuthType.UAF);
        }

        private void tb_Click(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null) tb.Text = "";
        }

        void UpdateState(string msg)
        {
            state.Text = msg;
            state.Invalidate();
        }

        private void close_Click(object Sender, EventArgs e)
        {
            Close();
        }
    }
}
