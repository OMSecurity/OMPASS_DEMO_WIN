# OMPASS Library v1.0 for Windows


![image](https://user-images.githubusercontent.com/105415486/204175639-78635f83-d390-4742-b619-21757f576070.png)


## Change Build Type to "x64"
![image](https://user-images.githubusercontent.com/105415486/204181580-ec9b7742-7961-4946-be27-fd65c93b3939.png)


## Install Microsoft.Web.WebView2 SDK Nuget package from nuget.org.

![image](https://user-images.githubusercontent.com/105415486/204176412-4b6c14b8-c4b5-4940-88a2-b3b00d25cc8c.png)




## Add 4 blue labelled files below to references in Project

* Add OmpassLib Path ( ./lib ) 
* Project Property -> Reference Paths -> Folder (./lib) -> Add Folder

![image](https://user-images.githubusercontent.com/105415486/204183239-c96c60ea-6540-4565-8e94-1d421480bd3d.png)


* add from Lib\OmpassLib.dll

![image](https://user-images.githubusercontent.com/105415486/204175686-308be936-2c13-4797-95da-8ee87eebda1b.png)



## Declare an OMPASS Agent

        // #1 : Declare an OMPASS agent
        OmpassLib.OmpassAgent agent;

## Add a Webview

* The UI Control size of the webview is required to be at least 
 <910x500>
 
 % The width size is responsive and it responds responsively according to the following size.
(910 or 768 or 540 or 360 or 280)

![image](https://user-images.githubusercontent.com/105415486/204176508-91878550-af7a-44b6-abe3-f74f1417fc1d.png)

         // #2 : Register a webview completion handler of initialization
         webView.CoreWebView2InitializationCompleted += WebView_CoreWebView2Ready;
         // #3 : Await the webview initialization
         await webView.EnsureCoreWebView2Async(null);


## Create an Ompass Instance

        public OmpassAgent(WebView2 webView, Action<string> callback, bool logEnable = true)

![image](https://user-images.githubusercontent.com/105415486/204223846-6ac86726-8f0d-4800-8e99-9abad68a5a46.png)

        // #4 : Complete the webview initialization
        private void WebView_CoreWebView2Ready(object sender, EventArgs e)
        {
            // #5 : Send webview to OmpassLib
            agent = new OmpassLib.OmpassAgent(webView, CallbackLogin);  





## Declare a Callback Function 

![image](https://user-images.githubusercontent.com/105415486/204176647-cc766aee-f1a3-441a-b0db-9dd44953e036.png)
      
        // #6 : Declare a callback function
        public void CallbackLogin(string data)
        {
            Console.WriteLine("{0}", data);
        }



## OMPASS Login API
* Request a two factor authentication API to login server

        public string Login(string url, string id, string pass, string lang, bool ssl = true)

![image](https://user-images.githubusercontent.com/105415486/204210524-84000184-d905-4b08-84bc-60e95eb199c3.png)

            //tb_url.Text = "https://192.168.182.77:9500";
            tb_url.Text = "login server url (Relying Party Server)";

            tb_id.Text = "id";
            tb_pass.Text = "password";
            tb_id.Show();
            tb_pass.Show();
            label_id.Show();
            label_pass.Show();

            // #7 : ompass Login API
            string ret = agent.Login(
                url_string,
                tb_id.Text,
                tb_pass.Text,
                tb_lang.Text);



## Error Codes
![image](https://user-images.githubusercontent.com/105415486/204176791-6de48990-0404-4a0c-94c5-58f073cacbd3.png)
