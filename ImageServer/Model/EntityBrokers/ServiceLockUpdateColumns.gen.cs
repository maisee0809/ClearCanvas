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

   public partial class ServiceLockUpdateColumns : EntityUpdateColumns
   {
       public ServiceLockUpdateColumns()
       : base("ServiceLock")
       {}
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="ServiceLockTypeEnum")]
        public ServiceLockTypeEnum ServiceLockTypeEnum
        {
            set { SubParameters["ServiceLockTypeEnum"] = new EntityUpdateColumn<ServiceLockTypeEnum>("ServiceLockTypeEnum", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="Lock")]
        public Boolean Lock
        {
            set { SubParameters["Lock"] = new EntityUpdateColumn<Boolean>("Lock", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="ScheduledTime")]
        public DateTime ScheduledTime
        {
            set { SubParameters["ScheduledTime"] = new EntityUpdateColumn<DateTime>("ScheduledTime", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="Enabled")]
        public Boolean Enabled
        {
            set { SubParameters["Enabled"] = new EntityUpdateColumn<Boolean>("Enabled", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="State")]
        public XmlDocument State
        {
            set { SubParameters["State"] = new EntityUpdateColumn<XmlDocument>("State", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="ServerPartitionGUID")]
        public ServerEntityKey ServerPartitionKey
        {
            set { SubParameters["ServerPartitionKey"] = new EntityUpdateColumn<ServerEntityKey>("ServerPartitionKey", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="FilesystemGUID")]
        public ServerEntityKey FilesystemKey
        {
            set { SubParameters["FilesystemKey"] = new EntityUpdateColumn<ServerEntityKey>("FilesystemKey", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="ProcessorId")]
        public String ProcessorId
        {
            set { SubParameters["ProcessorId"] = new EntityUpdateColumn<String>("ProcessorId", value); }
        }
    }
}
