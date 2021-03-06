﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_Project
{
    public class Test
    {
        int _id;
        int _projectId;
        string _name;
        string _description;
        User _handler;
        bool _isFinished;

        public Test(int id,int projectId, string name, string description)
        {
            this._id = id;
            this._projectId = projectId;
            this._name = name;
            this._description = description;
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public int ProjectID
        {
            get
            {
                return _projectId;
            }
        }

        public string NAME
        {
            get
            {
                return _name;
            }
        }

        public string DESC
        {
            get
            {
                return _description;
            }
        }

        public User Handler
        {
            get
            {
                return _handler;
            }
            set
            {
                _handler = value;
            }
        }

        public bool IsFinished
        {
            get
            {
                return _isFinished;
            }
            set
            {
                _isFinished = value;
            }
        }
    }
}
