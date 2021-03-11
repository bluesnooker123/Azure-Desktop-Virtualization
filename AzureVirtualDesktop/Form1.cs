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

using XPTable;
using XPTable.Models;

namespace AzureVirtualDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize_table();
        }
        private void Initialize_table()
        {
            this.table1.BeginUpdate();
            NumberColumn column0 = new NumberColumn("#", 20);
            TextColumn column1 = new TextColumn("File Name", 100);
            column0.Alignment = ColumnAlignment.Center;
            column1.Alignment = ColumnAlignment.Center;
            this.columnModel1.Columns.AddRange(new Column[] { column0 , column1 });

            this.table1.EndUpdate();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Please wait!");
            Add_Data_to_Table(Read_Data());
        }
        private void Add_Data_to_Table(List<string> data_list)
        {
            this.table1.TableModel.Rows.Clear();
            int i = 1;
            foreach(string row in data_list)
            {
                Row temp = new Row(new Cell[] { new Cell(i++), new Cell(row) });
                this.table1.TableModel.Rows.Add(temp);
            }
            if(data_list.Count != 0)
                MessageBox.Show("Load Success!");
        }
        private string Get_Token()
        {
            string token = "";
            try
            {
                var client = new RestClient("https://login.microsoftonline.com/6b358606-462c-40ce-96bc-5b2b81aa6230/oauth2/token");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                //request.AddHeader("Cookie", "esctx=AQABAAAAAAD--DLA3VO7QrddgJg7Wevr_HeeDGFFwhXCUnVftX43wV7LNFtNOVCPioXMxfyFaOvOCCwQM-d0cIU6fpQYb5VV4csMoxXTws4UUj8Njlc410fhEvn_lJapvYawKZPexcPSpMR7uIqb_FHRqNPsJ0LfZyIA82TdMfR6cvwO1uq6i7w89-CXl3DX7Aayr_7XCfYgAA; fpc=AgiHnQ1pqQZDr__jFNW_zy0pSIgTAQAAADGN29cOAAAAQjGucwEAAACRj9vXDgAAAA; stsservicecookie=estsfd; x-ms-gateway-slice=estsfd");
                request.AddParameter("grant_type", "client_credentials");
                request.AddParameter("client_id", "f3d892c5-e8f6-473f-a056-0e22b9e0a11b");
                request.AddParameter("resource", "https://management.core.windows.net/");
                request.AddParameter("client_secret", "jC1ykeJ.A.239x4.e1Y1Yw67FTR3y~YPDa");
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
        private List<string> Read_Data()
        {
            List<string> data = new List<string>();
            try
            {
                var client = new RestClient("https://management.azure.com/subscriptions/d96471f8-340c-42d6-92df-eba6fccca8e4/resourceGroups/msixaa/providers/Microsoft.DesktopVirtualization/applicationGroups/wvdtest-DAG/applications?api-version=2019-12-10-preview");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                string token = Get_Token();
                string Authorization_value = "";
                if (token.Length == 0)
                    return data;
                Authorization_value = "Bearer " + token;
                request.AddHeader("Authorization", Authorization_value);
                IRestResponse response = client.Execute(request);
                

                string[] temp = response.Content.Split(':');
                if (temp[0] == "{\"value\"")    //success
                {
                    response_data_form val_response = JsonConvert.DeserializeObject<response_data_form>(response.Content);
                    
                    foreach(response_data_list_form item in val_response.value)
                    {
                        data.Add(item.properties.friendlyName);
                    }

                }
                else
                {
                    MessageBox.Show("Can not get data using token", "Cannot get data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }
    }
}
