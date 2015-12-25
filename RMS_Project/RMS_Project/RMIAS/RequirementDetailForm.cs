﻿using System;
using Newtonsoft.Json.Linq;
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

namespace RMS_Project
{
    public partial class RequirementDetailForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        private Requirement _requirement;
        private UserInterfaceForm.FunctionalType type;

        public RequirementDetailForm(PresentationModel presentationModel, Requirement requirement)
        {
            InitializeComponent();
            _presentationModel = presentationModel;
            type = UserInterfaceForm.FunctionalType.Hide;
            RefreshRequirementDetail(requirement);
            _commentDataGridView.Columns[3].Visible = false;
        }

        public void RefreshRequirementDetail(Requirement requirement)
        {
            this._requirement = requirement;
            idLabel.Text = _requirement.ID.ToString();
            nameLabel.Text = _requirement.Name;
            versionLabel.Text = _requirement.Version;
            typeLabel.Text = _requirement.Type.Name;
            priorityLabel.Text = _requirement.Priority.Name;
            statusLabel.Text = _requirement.Status.Name;
            requirementOwnerLabel.Text = _requirement.Owner.Name;
            handlerLabel.Text = _requirement.Handler.Name;
            descriptionTextBox.Text = _requirement.Description;
            memoTextBox.Text = _requirement.Memo;
            getTestcaseByRequirementId();
            getComment();
        }

        public Requirement Requirement
        {
            get
            {
                return _requirement;
            }
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return type;
        }

        private async void getTestcaseByRequirementId()
        {
            HttpResponseMessage response = await _presentationModel.GetTestCaseListByRequirementId(_requirement.ID);
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                _associatedTestListDataGridView.Rows.Clear();
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["test_case_list"].ToString());
                if (message == "success")
                {
                    for (int i = 0; i < jsonArray.Count; i++)
                    {
                        JObject jObject = (JObject)jsonArray[i];
                        _associatedTestListDataGridView.Rows.Add(jObject["name"].ToString());
                    }
                }
            }
            else if (response.StatusCode == HttpStatusCode.RequestTimeout)
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("伺服器錯誤", "Error", MessageBoxButtons.OK);
            }
        }

        private async void getComment()
        {
            HttpResponseMessage response = await _presentationModel.GetCommentByRequirement(_requirement.ID);
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["comment_list"].ToString());
                if (message == "success")
                {
                    this._commentDataGridView.Rows.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        JObject jOwner = jObject["user"] as JObject;
                        User owner = _presentationModel.getUser((int)jOwner["id"], jOwner["name"].ToString());
                        this._commentDataGridView.Rows.Add(owner.Name, jObject["comment"], jObject["decision"]);
                    }
                }
            }
            else if (response.StatusCode == HttpStatusCode.RequestTimeout)
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("伺服器錯誤", "Error", MessageBoxButtons.OK);
            }
        }

        private async void CheckPriority()
        {
            JObject jObject = await _presentationModel.GetPriority(_requirement.ProjectID);
            if (jObject["priority_type_name"].ToString().Equals("Owner") ||
                jObject["priority_type_name"].ToString().Equals("Manager"))
            {
                type = UserInterfaceForm.FunctionalType.Edit;
                _commentDataGridView.Columns[3].Visible = true;
                _presentationModel.SetFunctionalButton(type);
            }
        }
    }
}
