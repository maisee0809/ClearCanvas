#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model.EntityBrokers
{
    using System;
    using System.Xml;
    using ClearCanvas.ImageServer.Enterprise;

   public partial class RestoreQueueUpdateColumns : EntityUpdateColumns
   {
       public RestoreQueueUpdateColumns()
       : base("RestoreQueue")
       {}
        [EntityFieldDatabaseMappingAttribute(TableName="RestoreQueue", ColumnName="ArchiveStudyStorageGUID")]
        public ServerEntityKey ArchiveStudyStorageKey
        {
            set { SubParameters["ArchiveStudyStorageKey"] = new EntityUpdateColumn<ServerEntityKey>("ArchiveStudyStorageKey", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="RestoreQueue", ColumnName="StudyStorageGUID")]
        public ServerEntityKey StudyStorageKey
        {
            set { SubParameters["StudyStorageKey"] = new EntityUpdateColumn<ServerEntityKey>("StudyStorageKey", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="RestoreQueue", ColumnName="ScheduledTime")]
        public DateTime ScheduledTime
        {
            set { SubParameters["ScheduledTime"] = new EntityUpdateColumn<DateTime>("ScheduledTime", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="RestoreQueue", ColumnName="RestoreQueueStatusEnum")]
        public RestoreQueueStatusEnum RestoreQueueStatusEnum
        {
            set { SubParameters["RestoreQueueStatusEnum"] = new EntityUpdateColumn<RestoreQueueStatusEnum>("RestoreQueueStatusEnum", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="RestoreQueue", ColumnName="ProcessorId")]
        public String ProcessorId
        {
            set { SubParameters["ProcessorId"] = new EntityUpdateColumn<String>("ProcessorId", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="RestoreQueue", ColumnName="FailureDescription")]
        public String FailureDescription
        {
            set { SubParameters["FailureDescription"] = new EntityUpdateColumn<String>("FailureDescription", value); }
        }
    }
}
