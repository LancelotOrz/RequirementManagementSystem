﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Json;
using Newtonsoft.Json.Linq;

namespace RMS_Project
{
    public partial class LoginForm : Form
    {
        private MainForm mainForm;

        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            try
            {
                email.Text = Properties.Settings.Default["email"].ToString();
                password.Text = Properties.Settings.Default["password"].ToString();
            }
            catch
            {

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void PostProduct()
        {
            JObject jObject = new JObject();
            jObject["email"] = email.Text;
            jObject["password"] = password.Text;

            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            Console.WriteLine(jObject.ToString());
            var httpClient = new HttpClient();
            try
            {
                response = await httpClient.PostAsync("http://140.124.183.32:3000/user/login", new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine(content);
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    string uid = json["uid"].ToString();
                    string name = json["name"].ToString();
                    if (message == "success")
                    {
                        if (rememberCheckBox.Checked)
                        {
                            Properties.Settings.Default["email"] = email.Text;
                            Properties.Settings.Default["password"] = password.Text;
                            Properties.Settings.Default["uid"] = uid;
                            Properties.Settings.Default["name"] = name;
                            Properties.Settings.Default.Save();
                        }
                        mainForm.AddFormToPanel(new ProjectListForm(mainForm));
                        mainForm.AddFormToNavigationPanel(new UserInterfaceForm(mainForm));
                    }
                    else
                    {
                        MessageBox.Show("帳號或密碼錯誤", "Error", MessageBoxButtons.OK);
                    }
                } 
                else
                {
                    MessageBox.Show("登入失敗", "Error", MessageBoxButtons.OK);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            mainForm.AddFormToPanel(new RegistrantionForm(mainForm));
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            PostProduct();
        }

    }
}
