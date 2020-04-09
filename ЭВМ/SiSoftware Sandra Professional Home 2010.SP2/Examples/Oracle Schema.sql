
--
-- Oracle 8i/9i/10g Schema for Sandra Report (Unicode)
--
-- Schema is assumed to have been created already.
-- No extents included, please add as required.
--
-- Copyright (c) 1995-2007, SiSoftware Ltd.
-- All Rights Reserved.

--
-- Kill all tables
--

DROP TABLE TItem;

DROP TABLE TControl;

DROP TABLE TItemGroup;

DROP TABLE TDevice;

DROP TABLE TClass;

DROP TABLE TModule;

DROP TABLE TReport;

DROP TABLE TIDCount;

DROP VIEW VItemNGroup;

--
-- Kill all sequences
--

DROP SEQUENCE seqTItem;

DROP SEQUENCE seqTControl;

DROP SEQUENCE seqTItemGroup;

DROP SEQUENCE seqTDevice;

DROP SEQUENCE seqTClass;

DROP SEQUENCE seqTModule;

DROP SEQUENCE seqTReport;

--
-- Create new sequences
--

CREATE SEQUENCE seqTItem;

CREATE SEQUENCE seqTControl;

CREATE SEQUENCE seqTItemGroup;

CREATE SEQUENCE seqTDevice;

CREATE SEQUENCE seqTClass;

CREATE SEQUENCE seqTModule;

CREATE SEQUENCE seqTReport;

--
-- Create new tables
--

CREATE TABLE TReport (
	ID			INTEGER PRIMARY KEY,
	ProgVersion		INTEGER NOT NULL,
	BuildVersion		INTEGER NOT NULL,
	Completed		NUMBER(1) NOT NULL
);

CREATE TABLE TModule (
	ID			INTEGER PRIMARY KEY,
	ReportID		INTEGER REFERENCES TReport(ID),
	Capabilities		INTEGER NOT NULL,
	Name			NVARCHAR2(255) NOT NULL,
	TypeID			INTEGER NOT NULL,
	HelpID			INTEGER NOT NULL
);

CREATE TABLE TClass (
	ID			INTEGER PRIMARY KEY,
	ModuleID		INTEGER REFERENCES TModule(ID),
	Name			NVARCHAR2(255) NOT NULL,
	IconID			INTEGER NOT NULL,
	HelpID			INTEGER NOT NULL
);

CREATE TABLE TDevice (
	ID			INTEGER PRIMARY KEY,
	ModuleID		INTEGER REFERENCES TModule(ID),
	ClassID			INTEGER REFERENCES TClass(ID),
	Name			NVARCHAR2(255) NOT NULL,
	IconID			INTEGER NOT NULL,
	HelpID			INTEGER NOT NULL
);

CREATE TABLE TItemGroup (
	ID			INTEGER PRIMARY KEY,
	ModuleID		INTEGER REFERENCES TModule(ID),
	ClassID			INTEGER REFERENCES TClass(ID),
	DeviceID		INTEGER REFERENCES TDevice(ID),
	Name			NVARCHAR2(255) NOT NULL,
	IconID			INTEGER NOT NULL,
	HelpID			INTEGER NOT NULL
);

CREATE TABLE TItem (
	ID			INTEGER PRIMARY KEY,
	ModuleID		INTEGER REFERENCES TModule(ID),
	ClassID			INTEGER REFERENCES TClass(ID),
	DeviceID		INTEGER REFERENCES TDevice(ID),
	GroupID			INTEGER REFERENCES TItemGroup(ID),
	Name			NVARCHAR2(255) NOT NULL,
	DataValue		NVARCHAR2(255),
	IconID			INTEGER NOT NULL,
	TypeID			INTEGER NOT NULL,
	HelpID			INTEGER NOT NULL
);

CREATE TABLE TControl (
	ID			INTEGER PRIMARY KEY,
	ModuleID		INTEGER REFERENCES TModule(ID),
	ClassID			INTEGER REFERENCES TClass(ID),
	DeviceID		INTEGER REFERENCES TDevice(ID),
	Name			INTEGER NOT NULL,
	DataValID		INTEGER NOT NULL,
	DataValue		NVARCHAR2(255)
);

CREATE TABLE TIDCount (
	TableName		NVARCHAR2(10) PRIMARY KEY,
	CurrentID		INTEGER NOT NULL
);

--
-- Set-up keys/indexes
--


CREATE INDEX ndxModuleParent ON TModule(ReportID);

CREATE INDEX ndxModuleType ON TModule(TypeID);

CREATE INDEX ndxClassParent ON TClass(ModuleID);

CREATE INDEX ndxClassType ON TClass(IconID);

CREATE INDEX ndxDeviceParent ON TDevice(ModuleID, ClassID);

CREATE INDEX ndxDeviceType ON TDevice(IconID);

CREATE INDEX ndxGroupParent ON TItemGroup(ModuleID, ClassID, DeviceID);

CREATE INDEX ndxGroupType ON TItemGroup(IconID);

CREATE INDEX ndxItemParent ON TItem(ModuleID, ClassID, DeviceID, GroupID);

CREATE INDEX ndxItemType ON TItem(IconID);

CREATE INDEX ndxControlParent ON TControl(ModuleID, ClassID, DeviceID);

CREATE INDEX ndxControlType ON TControl(Name);

--
-- Views
--

CREATE VIEW VItemNGroup
AS
SELECT
TItemGroup.ID AS TIG_ID, TItemGroup.ModuleID AS TIG_ModuleID, TItemGroup.ClassID AS TIG_ClassID,
TItemGroup.DeviceID AS TIG_DeviceID, TItemGroup.IconID AS TIG_IconID, TItemGroup.HelpID AS TIG_HelpID,
TItemGroup.Name AS TIG_Name, TItem.ID AS TI_ID, TItem.IconID AS TI_IconID, TItem.HelpID AS TI_HelpID,
TItem.Name AS TI_Name, TItem.TypeID, TItem.DataValue
FROM TItemGroup, TItem
WHERE TItem.GroupID=TItemGroup.ID;

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



