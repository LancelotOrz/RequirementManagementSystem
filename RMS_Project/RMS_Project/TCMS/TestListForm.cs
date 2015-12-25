﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class TestListForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        private Project _project;
        private Test _test;
        private ArrayList _arrayList;

        public TestListForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._project = project;
            _arrayList = new ArrayList();
            RefreshTestList();
        }

        public TestListForm(PresentationModel presentationModel, Test test)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._test = test;
            _arrayList = new ArrayList();
            RefreshTestList();
        }

        public async void RefreshTestList()
        {
            int projectId;
            projectId = (_project != null) ? _project.ID : _test.ProjectID;
            Console.WriteLine(projectId);
            HttpResponseMessage response = await _presentationModel.GetTestCaseListByProjectId(projectId);
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["test_case_list"].ToString());
                if (message == "success")
                {
                    this.testListDataGridView.Rows.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        this.testListDataGridView.Rows.Add(jObject["name"], jObject["id"]);
                        Test project = new Test(int.Parse(jObject["id"].ToString()), projectId, jObject["name"].ToString(), jObject["description"].ToString());
                        _arrayList.Add(project);
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

        public async void DeleteTestCase(int testCaseId)
        {
            try
            {
                string message = await _presentationModel.DeleteTestCase(testCaseId);
                RefreshTestList();
                MessageBox.Show(message, "Success", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void testListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("IN");
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                Console.WriteLine("按下刪除:" + e.RowIndex);
                Test test = _arrayList[e.RowIndex] as Test;
                DeleteTestCase(test.ID);
            }
            else
            {
                DataGridViewCell cell = testListDataGridView.Rows[e.RowIndex].Cells[0];
                Test test = _arrayList[e.RowIndex] as Test;
                Form form = new TestDetailForm(_presentationModel,test);
                Console.WriteLine("...................");
                if (_presentationModel.AddFormToPanel(form))
                    _presentationModel.AddFormButtonToUserInterface(form, cell.Value.ToString(), Properties.Resources.ios7_paper_outline);
            }
        }

        public Project Project
        {
            get
            {
                return _project;
            }
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.New;
        }
    }
}
