
--
-- SQL Server 2000/2005/2008 Schema for Sandra Report (Unicode)
--
-- Database is assumed to have been created already.
-- No size settings included, please add as required.
--
-- Copyright (c) 1995-2007, SiSoftware Ltd.
-- All Rights Reserved.
--

--USE Sandra;

--
-- Kill all tables
--

IF exists(select * from sysobjects where id = object_id('TItem') and OBJECTPROPERTY(id, 'IsTable') = 1)
DROP TABLE TItem;

IF exists(select * from sysobjects where id = object_id('TControl') and OBJECTPROPERTY(id, 'IsTable') = 1)
DROP TABLE TControl;

IF exists(select * from sysobjects where id = object_id('TItemGroup') and OBJECTPROPERTY(id, 'IsTable') = 1)
DROP TABLE TItemGroup;

IF exists(select * from sysobjects where id = object_id('TDevice') and OBJECTPROPERTY(id, 'IsTable') = 1)
DROP TABLE TDevice;

IF exists(select * from sysobjects where id = object_id('TClass') and OBJECTPROPERTY(id, 'IsTable') = 1)
DROP TABLE TClass;

IF exists(select * from sysobjects where id = object_id('TModule') and OBJECTPROPERTY(id, 'IsTable') = 1)
DROP TABLE TModule;

IF exists(select * from sysobjects where id = object_id('TReport') and OBJECTPROPERTY(id, 'IsTable') = 1)
DROP TABLE TReport;

IF exists(select * from sysobjects where id = object_id('TIDCount') and OBJECTPROPERTY(id, 'IsTable') = 1)
DROP TABLE TIDCount;

IF exists(select * from sysobjects where id = object_id('VItemNGroup') and OBJECTPROPERTY(id, 'IsView') = 1)
DROP VIEW VItemNGroup

--
-- Create new tables
--

CREATE TABLE TReport (
	ID			INT IDENTITY (1,1),
	
	ProgVersion		INT NOT NULL,
	BuildVersion		INT NOT NULL,
	Completed		BIT NOT NULL,

	CONSTRAINT		crpRIID PRIMARY KEY CLUSTERED (ID)
);

CREATE TABLE TModule (
	ID			INT IDENTITY (1,1),
	ReportID		INT NOT NULL,
	
	Capabilities		INT NOT NULL,
	Name			NVARCHAR(255) NOT NULL,
	TypeID			INT NOT NULL,
	HelpID			INT NOT NULL,

	CONSTRAINT		cmdMIID PRIMARY KEY CLUSTERED (ID),
	CONSTRAINT		cmdMRID FOREIGN KEY(ReportID) REFERENCES TReport(ID) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE TClass (
	ID			INT IDENTITY (1,1),
	ModuleID		INT NOT NULL,
	
	Name			NVARCHAR(255) NOT NULL,
	IconID			INT NOT NULL,
	HelpID			INT NOT NULL,

	CONSTRAINT		cclCIID PRIMARY KEY CLUSTERED (ID),
	CONSTRAINT		cclCMID FOREIGN KEY (ModuleID) REFERENCES TModule(ID) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE TDevice (
	ID			INT IDENTITY (1,1),
	ModuleID		INT NOT NULL,
	ClassID			INT,
	
	Name			NVARCHAR(255) NOT NULL,
	IconID			INT NOT NULL,
	HelpID			INT NOT NULL,

	CONSTRAINT		cdvDIID PRIMARY KEY CLUSTERED (ID),
	CONSTRAINT		cdvDMID FOREIGN KEY (ModuleID) REFERENCES TModule(ID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT		cdvDCID FOREIGN KEY (ClassID) REFERENCES TClass(ID) ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE TItemGroup (
	ID			INT IDENTITY (1,1),
	ModuleID		INT NOT NULL,
	ClassID			INT,
	DeviceID		INT,
	
	Name			NVARCHAR(255) NOT NULL,
	IconID			INT NOT NULL,
	HelpID			INT NOT NULL,

	CONSTRAINT		cigGIID PRIMARY KEY CLUSTERED (ID),
	CONSTRAINT		cigGMID FOREIGN KEY (ModuleID) REFERENCES TModule(ID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT		cigGCID FOREIGN KEY (ClassID) REFERENCES TClass(ID) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT		cigGDID FOREIGN KEY (DeviceID) REFERENCES TDevice(ID) ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE TItem (
	ID			INT IDENTITY (1,1),
	ModuleID		INT NOT NULL,
	ClassID			INT,
	DeviceID		INT,
	GroupID			INT,
	
	Name			NVARCHAR(255) NOT NULL,
	DataValue		NVARCHAR(255),
	IconID			INT NOT NULL,
	TypeID			INT NOT NULL,
	HelpID			INT NOT NULL,

	CONSTRAINT		citIIID PRIMARY KEY CLUSTERED (ID),
	CONSTRAINT		citIMID FOREIGN KEY (ModuleID) REFERENCES TModule(ID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT		citICID FOREIGN KEY (ClassID) REFERENCES TClass(ID) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT		citIDID FOREIGN KEY (DeviceID) REFERENCES TDevice(ID) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT		citIGID FOREIGN KEY (GroupID) REFERENCES TItemGroup(ID) ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE TControl (
	ID			INT IDENTITY (1,1),
	ModuleID		INT NOT NULL,
	ClassID			INT,
	DeviceID		INT,
	
	Name			INT NOT NULL,
	DataValID		INT NOT NULL,
	DataValue		NVARCHAR(255),

	CONSTRAINT		ccoTID PRIMARY KEY CLUSTERED (ID),
	CONSTRAINT		ccoTMID FOREIGN KEY (ModuleID) REFERENCES TModule(ID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT		ccoTCID FOREIGN KEY (ClassID) REFERENCES TClass(ID) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT		ccoTDID FOREIGN KEY (DeviceID) REFERENCES TDevice(ID) ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE TIDCount (
	TableName		NVARCHAR(10) NOT NULL,
	CurrentID		INT NOT NULL,
	
	CONSTRAINT		cidTabName PRIMARY KEY CLUSTERED (TableName)
);

--
-- Set-up keys/indexes
--

CREATE INDEX ndxModuleParent ON TModule (ReportID);

CREATE INDEX ndxModuleType ON TModule (TypeID);

CREATE INDEX ndxClassParent ON TClass (ModuleID);

CREATE INDEX ndxClassType ON TClass (IconID);

CREATE INDEX ndxDeviceParent ON TDevice (ModuleID, ClassID);

CREATE INDEX ndxDeviceType ON TDevice (IconID);

CREATE INDEX ndxGroupParent ON TItemGroup (ModuleID, ClassID, DeviceID);

CREATE INDEX ndxGroupType ON TItemGroup (IconID);

CREATE INDEX ndxItemParent ON TItem (ModuleID, ClassID, DeviceID, GroupID);

CREATE INDEX ndxItemType ON TItem (IconID);

CREATE INDEX ndxControlParent ON TControl (ModuleID, ClassID, DeviceID);

CREATE INDEX ndxControlType ON TControl (Name);

CREATE INDEX ndxIDCount ON TIDCount (TableName);
GO

--
-- Views
--

CREATE VIEW VItemNGroup
AS
SELECT TOP 100 PERCENT
[TItemGroup].[ID] AS TIG_ID, [TItemGroup].[ModuleID] AS TIG_ModuleID,
[TItemGroup].[ClassID] AS TIG_ClassID, [TItemGroup].[DeviceID] AS TIG_DeviceID,
[TItemGroup].[IconID] AS TIG_IconID, [TItemGroup].[HelpID] AS TIG_HelpID,
[TItemGroup].[Name] AS TIG_Name,
[TItem].[ID] AS TI_ID, [TItem].[IconID] AS TI_IconID, [TItem].[HelpID] AS TI_HelpID,
[TItem].[Name] AS TI_Name, [TItem].[TypeID], [TItem].[DataValue]
FROM TItemGroup, TItem
WHERE TItem.GroupID=TItemGroup.ID
ORDER BY TItemGroup.ID, TItem.ID
GO

--
-- Inserts
--

INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TItem', 1);
INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TControl', 1);
INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TItemGroup', 1);
INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TDevice', 1);
INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TClass', 1);
INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TModule', 1);
INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TReport', 1);
GO
