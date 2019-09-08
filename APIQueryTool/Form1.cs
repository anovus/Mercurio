using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json;

namespace APIQueryTool
{
    public partial class Mercurio : Form
    {
        static HttpClient client = new HttpClient();

        private bool _useAuthentication = false;

        public bool useAuthentication {

            get { return _useAuthentication; }
            set { _useAuthentication = value; }
        }

        public Mercurio()
        {
            InitializeComponent();

        }

        private string base64Credentials(string user, string password) {
            string creds = user + ":" + password;
            return Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(creds));
        }


        //Refactored InvokeButton_Click method to make use of HttpRequestMessage
        private async void InvokeButton_Click(object sender, EventArgs e)
        {
            if (!validateURL(uriBox2.Text))
            {

                responseBody.Text = "Invalid URL. URL must begin with http:// or https:// and must contain an address.";
            }
            else
            {
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(uriBox2.Text),
                    Method = HttpMethod.Get
                };
                var client = new HttpClient();


                loadHeaders(headersBox.Text, request);
                //  request.Content = new StringContent(payloadBox.Text, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                responseBox.Text = response.ToString();
                HttpContent content = response.Content;
                responseBody.Text = await content.ReadAsStringAsync();

                //Dispose of HTTPS client
                client.Dispose();
            }
        }




        //Refactored postButton_Click method to make use of HttpRequestMessage
        private async void postButton_Click(object sender, EventArgs e)
        {

            if (!validateURL(uriBox2.Text))
            {

               responseBody.Text = "Invalid URL. URL must begin with http:// or https:// and must contain an address.";
                
            }

            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(uriBox2.Text),
                    Method = HttpMethod.Post
                };
                
                loadHeaders(headersBox.Text, request);
                request.Content = new StringContent(payloadBox.Text, Encoding.UTF8, mediaTypeSelection.SelectedItem.ToString());

                var response = await client.SendAsync(request);
                responseBox.Text = response.ToString();

                //Dispose of HTTPClient
                client.Dispose();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private bool validateURL(string uriString) {

            //validate URL
            //If URL is malformed, display an error message in the Response Body textbox

            //if ((uriString.StartsWith("http://") || uriString.StartsWith("https://")) && uriString.Length > 9)
            //{
            //    return true;
            //}
            //return false;
            return Uri.IsWellFormedUriString(uriString,UriKind.Absolute);

        }
                
                
        

        private void authenticationToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (useAuthentication)
            {
                useAuthentication = false;

            }
            else
            {
                useAuthentication = true;
            }
        }

        public void loadHeaders(string headers, HttpRequestMessage request)
        {
            if (useAuthentication){
                request.Headers.Add("Authorization", "Basic " + base64Credentials(userBox.Text, passwordBox.Text));
            }
            StringReader strReader = new StringReader(headers);
            string line = null;

            while (true)
            {
                line=strReader.ReadLine();

                if (line != null) {

                    //remove whitespaces
                    line.Replace(" ",String.Empty);
                    //Extract Header Name and Value
                    string[] pair = line.Split(':');
                    request.Headers.Add(pair[0],pair[1]);
                }
                else {
                    break;
                }
            }
            }

        }


}



