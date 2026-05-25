-- データベース作成
IF NOT EXISTS (
    SELECT name 
    FROM master.dbo.sysdatabases 
    WHERE name = 'HachidoriTech'
)
BEGIN
    CREATE DATABASE HachidoriTech;
END
GO

USE HachidoriTech
GO

-- 資格実績テーブル
-- * BackupToTempTable
DROP TABLE IF EXISTS certified_licenses;

-- * RestoreFromTempTable
CREATE TABLE certified_licenses (
  employee_id int  NOT NULL
  , license_id int NOT NULL
  , certified_date date NOT NULL
  , CONSTRAINT certified_licenses_PKC PRIMARY KEY (employee_id,license_id)
) ;

-- 資格テーブル
-- * BackupToTempTable
DROP TABLE IF EXISTS licenses;

-- * RestoreFromTempTable
CREATE TABLE licenses (
  license_id int identity NOT NULL
  , license_name nvarchar(50) NOT NULL
  , authority nvarchar(50) NOT NULL
  , reward int NOT NULL
  , CONSTRAINT licenses_PKC PRIMARY KEY (license_id)
) ;

-- 社員テーブル
-- * BackupToTempTable
DROP TABLE IF EXISTS employees;

-- * RestoreFromTempTable
CREATE TABLE employees (
  employee_id int identity NOT NULL
  , employee_name nvarchar(50) NOT NULL
  , hire_date date NOT NULL
  , manager_id int
  , department_id int NOT NULL
  , CONSTRAINT employees_PKC PRIMARY KEY (employee_id)
) ;

-- 部署テーブル
-- * BackupToTempTable
DROP TABLE IF EXISTS departments;

-- * RestoreFromTempTable
CREATE TABLE departments (
  department_id int identity NOT NULL
  , department_name nvarchar(50) NOT NULL
  , CONSTRAINT departments_PKC PRIMARY KEY (department_id)
) ;

EXECUTE sp_addextendedproperty N'MS_Description', N'資格実績テーブル', N'SCHEMA', N'dbo', N'TABLE', N'certified_licenses', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'社員ID', N'SCHEMA', N'dbo', N'TABLE', N'certified_licenses', N'COLUMN', N'employee_id';
EXECUTE sp_addextendedproperty N'MS_Description', N'資格ID', N'SCHEMA', N'dbo', N'TABLE', N'certified_licenses', N'COLUMN', N'license_id';
EXECUTE sp_addextendedproperty N'MS_Description', N'取得日', N'SCHEMA', N'dbo', N'TABLE', N'certified_licenses', N'COLUMN', N'certified_date';

EXECUTE sp_addextendedproperty N'MS_Description', N'資格テーブル', N'SCHEMA', N'dbo', N'TABLE', N'licenses', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'資格ID', N'SCHEMA', N'dbo', N'TABLE', N'licenses', N'COLUMN', N'license_id';
EXECUTE sp_addextendedproperty N'MS_Description', N'資格名', N'SCHEMA', N'dbo', N'TABLE', N'licenses', N'COLUMN', N'license_name';
EXECUTE sp_addextendedproperty N'MS_Description', N'認定団体', N'SCHEMA', N'dbo', N'TABLE', N'licenses', N'COLUMN', N'authority';
EXECUTE sp_addextendedproperty N'MS_Description', N'資格手当', N'SCHEMA', N'dbo', N'TABLE', N'licenses', N'COLUMN', N'reward';

EXECUTE sp_addextendedproperty N'MS_Description', N'社員テーブル', N'SCHEMA', N'dbo', N'TABLE', N'employees', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'社員ID', N'SCHEMA', N'dbo', N'TABLE', N'employees', N'COLUMN', N'employee_id';
EXECUTE sp_addextendedproperty N'MS_Description', N'社員名', N'SCHEMA', N'dbo', N'TABLE', N'employees', N'COLUMN', N'employee_name';
EXECUTE sp_addextendedproperty N'MS_Description', N'入社日', N'SCHEMA', N'dbo', N'TABLE', N'employees', N'COLUMN', N'hire_date';
EXECUTE sp_addextendedproperty N'MS_Description', N'上司の社員ID', N'SCHEMA', N'dbo', N'TABLE', N'employees', N'COLUMN', N'manager_id';
EXECUTE sp_addextendedproperty N'MS_Description', N'部署ID', N'SCHEMA', N'dbo', N'TABLE', N'employees', N'COLUMN', N'department_id';

EXECUTE sp_addextendedproperty N'MS_Description', N'部署テーブル', N'SCHEMA', N'dbo', N'TABLE', N'departments', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'部署ID', N'SCHEMA', N'dbo', N'TABLE', N'departments', N'COLUMN', N'department_id';
EXECUTE sp_addextendedproperty N'MS_Description', N'部署名', N'SCHEMA', N'dbo', N'TABLE', N'departments', N'COLUMN', N'department_name';

INSERT INTO departments (department_name) VALUES ('営業部');
INSERT INTO departments (department_name) VALUES ('開発部');
INSERT INTO departments (department_name) VALUES ('人事部');
INSERT INTO departments (department_name) VALUES ('経理部');
INSERT INTO departments (department_name) VALUES ('マーケティング部');

INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('山田 太郎', '1998-04-01', NULL, 1);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('佐藤 次郎', '2001-04-01', 1, 1);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('鈴木 三郎', '2005-04-01', 1, 1);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('高橋 郁子', '2012-04-01', 1, 1);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('田中 俊平', '2018-04-01', NULL, 2);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('渡辺 佳奈', '2020-04-01', 5, 2);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('伊藤 裕子', '2008-04-01', NULL, 3);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('木村 大樹', '2010-04-01', 7, 3);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('加藤 優子', '2014-04-01', NULL, 4);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('中村 晃子', '2000-04-01', 9, 4);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('山本 知実', '2002-04-01', NULL, 5);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('五十嵐 雄太', '2019-04-01', 11, 5);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('五十嵐 京子', '2022-04-01', 5, 5);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('小林 貴史', '2004-04-01', 6, 2);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('小野 和也', '2003-04-01', 7, 3);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('石川 知子', '2007-04-01', 7, 3);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('村上 春樹', '2016-04-01', 8, 4);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('吉田 知美', '2009-03-15', 9, 1);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('田口 恵子', '2021-04-01', 10, 5);
INSERT INTO employees (employee_name, hire_date, manager_id, department_id) VALUES ('渡辺 真理', '2018-04-01', 11, 2);

INSERT INTO licenses (license_name, authority, reward) VALUES ('基本情報技術者試験', '情報処理推進機構', 10000);
INSERT INTO licenses (license_name, authority, reward) VALUES ('応用情報技術者試験', '情報処理推進機構', 20000);
INSERT INTO licenses (license_name, authority, reward) VALUES ('Cisco CCNA', 'シスコシステムズ', 15000);
INSERT INTO licenses (license_name, authority, reward) VALUES ('Cisco CCNP', 'シスコシステムズ', 30000);
INSERT INTO licenses (license_name, authority, reward) VALUES ('Microsoft Azure Fundamentals', 'マイクロソフト', 12000);
INSERT INTO licenses (license_name, authority, reward) VALUES ('Microsoft Azure Administrator', 'マイクロソフト', 22000);
INSERT INTO licenses (license_name, authority, reward) VALUES ('AWS Certified Cloud Practitioner', 'Amazon Web Services', 12000);
INSERT INTO licenses (license_name, authority, reward) VALUES ('AWS Certified Solutions Architect - Associate', 'Amazon Web Services', 25000);
INSERT INTO licenses (license_name, authority, reward) VALUES ('英検 1級', '日本英語検定協会', 18000);
INSERT INTO licenses (license_name, authority, reward) VALUES ('英検 準1級', '日本英語検定協会', 12000);
INSERT INTO licenses (license_name, authority, reward) VALUES ('TOEIC 860点以上', 'ETS', 15000);
INSERT INTO licenses (license_name, authority, reward) VALUES ('スーパーエンジニア検定1級', 'ウチダ人材開発センタ', 1000000);

INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (1, 1, '2001-04-24');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (6, 4, '2002-02-15');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (5, 5, '2003-05-17');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (4, 4, '2004-07-22');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (5, 3, '2005-12-30');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (6, 7, '2006-03-05');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (6, 9, '2007-11-21');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (2, 1, '2008-06-09');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (1, 2, '2009-09-01');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (9, 4, '2010-08-10');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (17, 11, '2011-04-29');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (16, 7, '2012-10-16');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (13, 9, '2013-01-07');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (18, 2, '2014-06-25');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (15, 9, '2015-12-01');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (16, 5, '2016-05-21');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (17, 1, '2017-03-18');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (6, 3, '2018-08-27');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (9, 5, '2019-07-15');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (20, 6, '2020-01-25');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (4, 9, '2021-02-03');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (2, 10, '2021-11-12');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (3, 11, '2022-04-10');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (14, 4, '2022-05-28');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (15, 7, '2023-01-19');
INSERT INTO certified_licenses (employee_id, license_id, certified_date) VALUES (19, 8, '2023-05-01');
