
#
# mySQL 4.x/5.x Schema for Sandra Report (Unicode)
#
# Database is assumed to have been created already.
# No size settings included, please add as required.
#
# Copyright (c) 1995-2007, SiSoftware Ltd.
# All Rights Reserved.

#
# Kill all tables
#

DROP TABLE TItem;

DROP TABLE TControl;

DROP TABLE TItemGroup;

DROP TABLE TDevice;

DROP TABLE TClass;

DROP TABLE TModule;

DROP TABLE TReport;

DROP TABLE TIDCount;

#
# Create new tables
#

CREATE TABLE TReport (
	ID			INT NOT NULL,
	
	ProgVersion		INT NOT NULL,
	BuildVersion		INT NOT NULL,
	Completed		BIT NOT NULL,
	
	PRIMARY KEY (ID)
) TYPE = INNODB;

CREATE TABLE TModule (
	ID			INT NOT NULL,
	ReportID		INT NOT NULL,
	
	Capabilities		INT NOT NULL,
	Name			VARCHAR(255) CHARACTER SET ucs2 NOT NULL,
	TypeID			INT NOT NULL,
	HelpID			INT NOT NULL,
	
	PRIMARY KEY (ID),
	INDEX (ReportID),
	
	FOREIGN KEY (ReportID) REFERENCES TReport(ID)
) TYPE = INNODB;

CREATE TABLE TClass (
	ID			INT NOT NULL,
	ModuleID		INT NOT NULL,
	
	Name			VARCHAR(255) CHARACTER SET ucs2 NOT NULL,
	IconID			INT NOT NULL,
	HelpID			INT NOT NULL,
	
	PRIMARY KEY (ID),
	INDEX (ModuleID),
	
	FOREIGN KEY(ModuleID) REFERENCES TModule(ID)
) TYPE = INNODB;

CREATE TABLE TDevice (
	ID			INT NOT NULL,
	ModuleID		INT NOT NULL,
	ClassID			INT,
	
	Name			VARCHAR(255) CHARACTER SET ucs2 NOT NULL,
	IconID			INT NOT NULL,
	HelpID			INT NOT NULL,
	
	PRIMARY KEY (ID),
	INDEX (ModuleID),
	INDEX (ClassID),
	
	FOREIGN KEY(ModuleID) REFERENCES TModule(ID),
	FOREIGN KEY(ClassID) REFERENCES TClass(ID)
) TYPE = INNODB;

CREATE TABLE TItemGroup (
	ID			INT NOT NULL,
	ModuleID		INT NOT NULL,
	ClassID			INT,
	DeviceID		INT,
	
	Name			VARCHAR(255) CHARACTER SET ucs2 NOT NULL,
	IconID			INT NOT NULL,
	HelpID			INT NOT NULL,
	
	PRIMARY KEY (ID),
	INDEX (ModuleID),
	INDEX (ClassID),
	INDEX (DeviceID),
	
	FOREIGN KEY(ModuleID) REFERENCES TModule(ID),
	FOREIGN KEY(ClassID) REFERENCES TClass(ID),
	FOREIGN KEY(DeviceID) REFERENCES TDevice(ID)
) TYPE = INNODB;

CREATE TABLE TItem (
	ID			INT NOT NULL,
	ModuleID		INT NOT NULL,
	ClassID			INT,
	DeviceID		INT,
	GroupID			INT,
	
	Name			VARCHAR(255) CHARACTER SET ucs2 NOT NULL,
	DataValue		VARCHAR(255) CHARACTER SET ucs2,
	IconID			INT NOT NULL,
	TypeID			INT NOT NULL,
	HelpID			INT NOT NULL,
	
	PRIMARY KEY (ID),
	INDEX (ModuleID),
	INDEX (ClassID),
	INDEX (DeviceID),
	INDEX (GroupID),
	
	FOREIGN KEY(ModuleID) REFERENCES TModule(ID),
	FOREIGN KEY(ClassID) REFERENCES TClass(ID),
	FOREIGN KEY(DeviceID) REFERENCES TDevice(ID),
	FOREIGN KEY(GroupID) REFERENCES TItemGroup(ID)
) TYPE = INNODB;

CREATE TABLE TControl (
	ID			INT NOT NULL,
	ModuleID		INT NOT NULL,
	ClassID			INT,
	DeviceID		INT,
	
	Name			INT NOT NULL,
	DataValID		INT NOT NULL,
	DataValue		VARCHAR(255) CHARACTER SET ucs2,
	
	PRIMARY KEY (ID),
	INDEX (ModuleID),
	INDEX (ClassID),
	INDEX (DeviceID),
	
	FOREIGN KEY(ModuleID) REFERENCES TModule(ID),
	FOREIGN KEY(ClassID) REFERENCES TClass(ID),
	FOREIGN KEY(DeviceID) REFERENCES TDevice(ID)
) TYPE = INNODB;

CREATE TABLE TIDCount (
	TableName		VARCHAR(10) CHARACTER SET ucs2,
	CurrentID		INT NOT NULL,
	
	PRIMARY KEY(TableName)
) TYPE = INNODB;

#
# Inserts
#

INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TItem', 1);
INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TControl', 1);
INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TItemGroup', 1);
INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TDevice', 1);
INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TClass', 1);
INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TModule', 1);
INSERT INTO TIDCount (TableName, CurrentID) VALUES ('TReport', 1);

