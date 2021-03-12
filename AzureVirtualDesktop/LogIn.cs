using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using RestSharp;
using Newtonsoft.Json;

namespace AzureVirtualDesktop
{
    public partial class LogIn : Form
    {
        public string m_token;
        public LogIn()
        {
            InitializeComponent();
            m_token = "";
            this.FormClosing += frmLogin_Closing;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input_client_id.Text))
            {
                MessageBox.Show("Please enter client_id.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                input_client_id.Focus();
                return;
            }
            if (string.IsNullOrEmpty(input_client_secret.Text))
            {
                MessageBox.Show("Please enter Client_secret.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                input_client_secret.Focus();
                return;
            }
            m_token = Get_Token();
            if(m_token.Length != 0)
                this.Hide();
        }
        private string Get_Token()
        {
            string token = "";
            try
            {
                string baseURL = "https://login.microsoftonline.com/" + input_tenant_id.Text + "/oauth2/token";
                //var client = new RestClient("https://login.microsoftonline.com/6b358606-462c-40ce-96bc-5b2b81aa6230/oauth2/token");
                var client = new RestClient(baseURL);
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                //request.AddHeader("Cookie", "esctx=AQABAAAAAAD--DLA3VO7QrddgJg7Wevr_HeeDGFFwhXCUnVftX43wV7LNFtNOVCPioXMxfyFaOvOCCwQM-d0cIU6fpQYb5VV4csMoxXTws4UUj8Njlc410fhEvn_lJapvYawKZPexcPSpMR7uIqb_FHRqNPsJ0LfZyIA82TdMfR6cvwO1uq6i7w89-CXl3DX7Aayr_7XCfYgAA; fpc=AgiHnQ1pqQZDr__jFNW_zy0pSIgTAQAAADGN29cOAAAAQjGucwEAAACRj9vXDgAAAA; stsservicecookie=estsfd; x-ms-gateway-slice=estsfd");
                request.AddParameter("grant_type", "client_credentials");
                //request.AddParameter("client_id", "f3d892c5-e8f6-473f-a056-0e22b9e0a11b");
                request.AddParameter("client_id", input_client_id.Text);
                request.AddParameter("resource", "https://management.core.windows.net/");
                //request.AddParameter("client_secret", "jC1ykeJ.A.239x4.e1Y1Yw67FTR3y~YPDa");
                request.AddParameter("client_secret", input_client_secret.Text);
                IRestResponse response = client.Execute(request);

                string[] temp = response.Content.Split(',');
                if (temp[0] == "{\"token_type\":\"Bearer\"")
                {
                    response_token_form val_response = JsonConvert.DeserializeObject<response_token_form>(response.Content);
                    token = val_response.access_token;
                }
                else
                {
                    MessageBox.Show("Can not get access_token", "Cannot get token", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return token;
        }
        private void frmLogin_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //MessageBox.Show("frmLogin Closing
            if(m_token == "")
                System.Windows.Forms.Application.Exit();
        }


    }
}
