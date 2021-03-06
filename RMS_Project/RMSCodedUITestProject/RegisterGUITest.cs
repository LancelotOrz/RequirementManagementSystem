﻿﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using ezLogUITest;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System.Timers;


namespace RMSCodedUITestProject
{
    /// <summary>
    /// RegisterGUITest 的摘要描述
    /// </summary>
    [CodedUITest]
    public class RegisterGUITest
    {
        private string FILE_PATH = "../../../RMS_Project/bin/debug/RMS_Project.exe";
        private string UI_TESTING_EXAMPLE_TITLE = "RMS_Project";
        private UITestControl _root;

        [TestInitialize()]
        public void Initialize()
        {
            _root = Robot.Initialize(FILE_PATH, UI_TESTING_EXAMPLE_TITLE);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        [TestMethod]
        [DeploymentItem("RMS_Project.exe")]
        public void RegisterError()
        {
            Robot.ClickOtherFormButton("loginForm", "createAccountButton");
            //帳號存在
            Robot.SetOtherFormEdit("registrantionForm", "userNameLabel", "ZZ");
            Robot.SetOtherFormEdit("registrantionForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.SetOtherFormUseSystemPasswordChar("registrantionForm", "passwordLabel", "a123456");
            Robot.SetOtherFormUseSystemPasswordChar("registrantionForm", "confirmPasswordLabel", "a123456");

            //assert輸入值沒錯
            Robot.AssertOtherFormEdit("registrantionForm", "userNameLabel", "ZZ");
            Robot.AssertOtherFormEdit("registrantionForm", "emailLabel", "j00064qaz123@gmail.com");

            Robot.ClickOtherFormDoubleButton("registrantionForm", "createAccountButton");
            //messageBox錯誤
            Robot.AssertWindowExist("Error", true);
            Robot.ClickOtherFormButton("Error", "確定");
            //按下messageButton後，回到registrantionForm
            Robot.AssertWindowExist("registrantionForm", true);
        }

        [TestMethod]
        [DeploymentItem("RMS_Project.exe")]
        public void RegisterSuccess()
        {
            Robot.ClickOtherFormButton("loginForm", "createAccountButton");
            //帳號不存在
            Robot.SetOtherFormEdit("registrantionForm", "userNameLabel", "ZZ");
            Robot.SetOtherFormEdit("registrantionForm", "emailLabel", "a00064qaz123@gmail.com");
            Robot.SetOtherFormUseSystemPasswordChar("registrantionForm", "passwordLabel", "a123456");
            Robot.SetOtherFormUseSystemPasswordChar("registrantionForm", "confirmPasswordLabel", "a123456");

            //assert輸入值沒錯
            Robot.AssertOtherFormEdit("registrantionForm", "userNameLabel", "ZZ");
            Robot.AssertOtherFormEdit("registrantionForm", "emailLabel", "a00064qaz123@gmail.com");

            Robot.ClickOtherFormButton("registrantionForm", "createAccountButton");
            //messageBox成功
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            //按下messageButton後，回到loginForm
            Robot.AssertWindowExist("loginForm", true);
        }
    }
}
