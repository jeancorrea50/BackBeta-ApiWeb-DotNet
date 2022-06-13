﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Models
{
    public class UserModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private DateTime? _CreateAt;
        public DateTime? CreateAt
        {
            get { return _CreateAt; }
            set { _CreateAt = (value == null ? DateTime.UtcNow : value); }
        }

        private DateTime _updateAt;
        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }

    }
}
