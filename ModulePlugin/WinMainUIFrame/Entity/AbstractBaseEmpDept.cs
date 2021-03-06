﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFWCoreLib.CoreFrame.Orm;
using ProtoBuf;

namespace WinMainUIFrame.Entity
{
    [Serializable]
    [ProtoContract]
    [Table(TableName = "BaseEmpDept", EntityType = EntityType.Table, IsGB = false)]
    public class BaseEmpDept:EFWCoreLib.CoreFrame.Business.AbstractEntity
    {
        private int  _id;
        /// <summary>
        /// 
        /// </summary>
        [Column(FieldName = "Id", DataKey = true,  Match = "", IsInsert = false)]
        [ProtoMember(1)]
        public int Id
        {
            get { return  _id; }
            set {  _id = value; }
        }

        private int  _empid;
        /// <summary>
        /// 人员ID
        /// </summary>
        [Column(FieldName = "EmpId", DataKey = false,  Match = "", IsInsert = true)]
        [ProtoMember(2)]
        public int EmpId
        {
            get { return  _empid; }
            set {  _empid = value; }
        }

        private int  _defaultflag;
        /// <summary>
        /// 默认科室标志
        /// </summary>
        [Column(FieldName = "DefaultFlag", DataKey = false,  Match = "", IsInsert = true)]
        [ProtoMember(3)]
        public int DefaultFlag
        {
            get { return  _defaultflag; }
            set {  _defaultflag = value; }
        }

        private int  _deptid;
        /// <summary>
        /// 科室ID
        /// </summary>
        [Column(FieldName = "DeptId", DataKey = false,  Match = "", IsInsert = true)]
        [ProtoMember(4)]
        public int DeptId
        {
            get { return  _deptid; }
            set {  _deptid = value; }
        }

    }
}
