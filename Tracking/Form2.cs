using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace Tracking
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnfecthip_Click(object sender, EventArgs e)
        {
            txtresult.Text=fetchiplocation();
        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            if (txtip.Text.Equals("")==false)
            {
                txtresult.Text=fetchiplocation(txtip.Text);
            }
            
        }

        private string fetchiplocation()
        {
            string strIplocation = string.Empty;
            var client =new RestClient("https://ipapi.co/json");
            var request = new RestRequest()
            {
                Method = Method.GET
            };
            var response=client.Execute(request);
            //  strIplocation = response.Content;
            var dictionary=JsonConvert.DeserializeObject<IDictionary>(response.Content);
            foreach (var key in dictionary.Keys)
            {
                strIplocation +=key.ToString() + ":" + dictionary[key] +"\r\n";
            }
            return strIplocation;
        }

        private string fetchiplocation(string StrIP)
        {
            string strIplocation = string.Empty;
            var client = new RestClient("https://ipapi.co/"+ StrIP+"/json/");
            var request = new RestRequest()
            {
                Method = Method.GET
            };
            var response = client.Execute(request);
            //  strIplocation = response.Content;
            var dictionary = JsonConvert.DeserializeObject<IDictionary>(response.Content);
            foreach (var key in dictionary.Keys)
            {
                strIplocation = key.ToString() + ":" + dictionary[key] + "\r\n";
            }
            return strIplocation;
        }
    }
}
