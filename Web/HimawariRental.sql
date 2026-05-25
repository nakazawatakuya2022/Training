-- データベース作成
IF NOT EXISTS (
    SELECT name
    FROM master.dbo.sysdatabases
    WHERE name = 'HimawariRental'
)
BEGIN
    CREATE DATABASE HimawariRental;
END
GO

USE HimawariRental
GO

-- レンタル履歴
DROP TABLE IF EXISTS rental_histories;

-- 顧客
DROP TABLE IF EXISTS customers;

-- 職員
DROP TABLE IF EXISTS staffs;

-- レンタル品
DROP TABLE IF EXISTS rental_items;

-- カテゴリ
DROP TABLE IF EXISTS categories;

CREATE TABLE staffs (
  staff_id varchar(8) NOT NULL
  , staff_name nvarchar(20) NOT NULL
  , password varchar(8) NOT NULL
  , role tinyint NOT NULL
  , CONSTRAINT staffs_PKC PRIMARY KEY (staff_id)
);

CREATE TABLE customers (
  customer_code varchar(10) NOT NULL
  , customer_name nvarchar(50) NOT NULL
  , customer_kana nvarchar(50) NOT NULL
  , gender tinyint NOT NULL
  , zip_code varchar(8) NOT NULL
  , address1 nvarchar(100) NOT NULL
  , address2 nvarchar(100)
  , tel varchar(20) NOT NULL
  , email varchar(50)
  , memo nvarchar(200)
  , input_date date NOT NULL
  , CONSTRAINT customers_PKC PRIMARY KEY (customer_code)
);

CREATE TABLE categories (
  category_id int identity NOT NULL
  , category_name nvarchar(20) NOT NULL
  , CONSTRAINT categories_PKC PRIMARY KEY (category_id)
);

CREATE TABLE rental_items (
  rental_item_id int identity NOT NULL
  , management_code varchar(17) NOT NULL
  , item_name nvarchar(100) NOT NULL
  , maker nvarchar(30) NOT NULL
  , storage_location nvarchar(30) NOT NULL
  , purchase_date date NOT NULL
  , purchase_price int NOT NULL
  , memo nvarchar(200)
  , category_id int NOT NULL
  , rental_flag tinyint NOT NULL
  , CONSTRAINT rental_items_PKC PRIMARY KEY (rental_item_id)
);

CREATE TABLE rental_histories (
  customer_code varchar(10) NOT NULL
  , rental_item_id int NOT NULL
  , rental_date date NOT NULL
  , return_date date NOT NULL
  , memo nvarchar(200)
  , has_returned tinyint NOT NULL
  , CONSTRAINT rental_histories_PKC PRIMARY KEY (customer_code,rental_item_id,rental_date)
);

EXECUTE sp_addextendedproperty N'MS_Description', N'職員', N'SCHEMA', N'dbo', N'TABLE', N'staffs', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'顧客', N'SCHEMA', N'dbo', N'TABLE', N'customers', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'カテゴリ', N'SCHEMA', N'dbo', N'TABLE', N'categories', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'レンタル品', N'SCHEMA', N'dbo', N'TABLE', N'rental_items', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'レンタル履歴', N'SCHEMA', N'dbo', N'TABLE', N'rental_histories', NULL, NULL;

INSERT INTO staffs (staff_id, staff_name, password, role) VALUES
('40000001', '山口健太', 'abcd1234', 1),
('40000002', '田村絵美', 'pqrs5678', 0),
('40000003', '高橋誠', 'xyzw9012', 0);

INSERT INTO customers (customer_code, customer_name, customer_kana, gender, zip_code, address1, address2, tel, email, memo, input_date) VALUES
('C000000001', '田中太郎', 'タナカタロウ', 1, '123-4567', '東京都千代田区1-1-1', NULL, '03-1234-5678', 'tanaka.taro@example.com', NULL, '2022-01-10'),
('C000000002', '山本花子', 'ヤマモトハナコ', 2, '567-8901', '大阪府大阪市北区2-2-2', NULL, '06-2345-6789', 'yamamoto.hanako@example.com', NULL, '2022-03-18'),
('C000000003', '佐藤三郎', 'サトウサブロウ', 1, '890-1234', '神奈川県横浜市中区3-3-3', NULL, '045-3456-7890', 'sato.saburo@example.com', NULL, '2022-08-21'),
('C000000004', '鈴木美紀', 'スズキミキ', 2, '567-8910', '京都府京都市左京区4-4-4', NULL, '075-4567-8901', 'suzuki.miki@example.com', NULL, '2023-01-12'),
('C000000005', '高橋健介', 'タカハシケンスケ', 1, '123-0987', '東京都渋谷区5-5-5', NULL, '090-6789-0123', 'takahashi.kensuke@example.com', NULL, '2023-04-02'),
('C000000006', '伊藤麻美', 'イトウマミ', 2, '987-6543', '福岡県福岡市博多区6-6-6', NULL, '092-7890-1234', 'ito.mami@example.com', NULL, '2023-07-16'),
('C000000007', '中村京子', 'ナカムラキョウコ', 2, '234-5678', '広島県広島市中区7-7-7', NULL, '082-2345-6789', 'nakamura.kyoko@example.com', NULL, '2023-10-09'),
('C000000008', '山田健太', 'ヤマダケンタ', 1, '987-6500', '兵庫県神戸市中央区8-8-8', NULL, '078-5678-9012', 'yamada.kenta@example.com', NULL, '2024-02-11'),
('C000000009', '田中麻子', 'タナカアサコ', 2, '432-1098', '東京都港区9-9-9', NULL, '03-9012-3456', 'tanaka.asako@example.com', NULL, '2024-06-23'),
('C000000010', '小林亮', 'コバヤシリョウ', 1, '060-0001', '北海道札幌市中央区10-10-10', NULL, '011-1111-2222', 'kobayashi.ryo@example.com', NULL, '2024-09-05');

INSERT INTO categories (category_name) VALUES
('テント・タープ'),
('調理器具'),
('寝具'),
('ライト・電源'),
('登山用品');

INSERT INTO rental_items (management_code, item_name, maker, storage_location, purchase_date, purchase_price, memo, category_id, rental_flag) VALUES
('OUT-0001', 'ファミリーテント4人用', 'NorthField', 'A棚-01', '2021-04-10', 68000, NULL, 1, 1),
('OUT-0002', 'ソロテント軽量', 'TrailWorks', 'A棚-02', '2022-03-12', 32000, NULL, 1, 1),
('OUT-0003', 'ヘキサタープ', 'SunnyCamp', 'A棚-03', '2021-06-05', 26000, NULL, 1, 0),
('OUT-0004', 'ロールテーブル', 'CampBase', 'B棚-01', '2020-09-17', 9800, NULL, 2, 0),
('OUT-0005', 'ツーバーナー', 'FlamePro', 'B棚-02', '2022-02-20', 21000, NULL, 2, 0),
('OUT-0006', '焚き火台', 'IronPeak', 'B棚-03', '2021-11-11', 14500, '脚に小さな擦れあり', 2, 0),
('OUT-0007', 'クッカーセット', 'MealTrail', 'B棚-04', '2023-01-19', 7800, NULL, 2, 0),
('OUT-0008', 'LEDランタン大', 'BrightWay', 'C棚-01', '2020-05-25', 8900, NULL, 4, 0),
('OUT-0009', 'ポータブル電源500W', 'VoltCamp', 'C棚-02', '2023-06-03', 59000, NULL, 4, 1),
('OUT-0010', 'ヘッドライト', 'BrightWay', 'C棚-03', '2022-07-14', 4200, NULL, 4, 0),
('OUT-0011', 'シュラフ春秋用', 'SleepWell', 'D棚-01', '2021-10-02', 12000, NULL, 3, 0),
('OUT-0012', 'インフレーターマット', 'SleepWell', 'D棚-02', '2022-08-08', 13500, NULL, 3, 0),
('OUT-0013', 'アウトドアコット', 'CampBase', 'D棚-03', '2023-03-09', 18000, NULL, 3, 0),
('OUT-0014', 'バックパック45L', 'TrailWorks', 'E棚-01', '2020-04-22', 22000, NULL, 5, 0),
('OUT-0015', 'トレッキングポール', 'MountainStep', 'E棚-02', '2021-08-28', 9800, NULL, 5, 0),
('OUT-0016', 'アウトドアチェア', 'CampBase', 'A棚-04', '2023-05-30', 7600, NULL, 1, 0),
('OUT-0017', 'クーラーボックス', 'CoolStock', 'B棚-05', '2021-07-03', 16800, NULL, 2, 0),
('OUT-0018', 'ウォータージャグ', 'AquaCamp', 'B棚-06', '2022-04-18', 6800, NULL, 2, 0),
('OUT-0019', 'レインウェア上下', 'TrailWorks', 'E棚-03', '2021-05-12', 19800, NULL, 5, 0),
('OUT-0020', 'ハンモック', 'SunnyCamp', 'A棚-05', '2023-09-01', 12500, NULL, 1, 0),
('OUT-0021', '焚き火シート', 'IronPeak', 'B棚-07', '2024-01-13', 3900, NULL, 2, 1),
('OUT-0022', 'ダッチオーブン', 'IronPeak', 'B棚-08', '2020-12-21', 15500, '重いため持ち運び注意', 2, 0),
('OUT-0023', 'スノーシュー', 'SnowLine', 'E棚-04', '2023-12-04', 24000, NULL, 5, 0),
('OUT-0024', 'ファーストエイドセット', 'SafeTrail', 'E棚-05', '2024-03-06', 5200, NULL, 5, 0);

INSERT INTO rental_histories (customer_code, rental_item_id, rental_date, return_date, memo, has_returned) VALUES
('C000000001', 1, '2023-04-29', '2023-05-03', NULL, 1),
('C000000002', 1, '2023-07-15', '2023-07-18', NULL, 1),
('C000000003', 1, '2024-04-27', '2024-05-01', NULL, 1),
('C000000004', 1, '2024-08-10', '2024-08-14', NULL, 1),
('C000000005', 1, '2025-04-26', '2025-04-30', NULL, 1),
('C000000006', 2, '2023-05-20', '2023-05-22', NULL, 1),
('C000000007', 2, '2023-09-16', '2023-09-18', NULL, 1),
('C000000008', 2, '2024-03-30', '2024-04-01', NULL, 1),
('C000000009', 2, '2024-09-21', '2024-09-23', NULL, 1),
('C000000010', 2, '2025-02-08', '2025-02-10', NULL, 1),
('C000000001', 3, '2023-06-03', '2023-06-05', NULL, 1),
('C000000002', 3, '2024-05-18', '2024-05-20', NULL, 1),
('C000000003', 3, '2025-05-03', '2025-05-05', NULL, 1),
('C000000004', 4, '2023-08-11', '2023-08-13', NULL, 1),
('C000000005', 4, '2024-06-22', '2024-06-24', NULL, 1),
('C000000006', 4, '2025-03-15', '2025-03-17', NULL, 1),
('C000000007', 5, '2023-10-07', '2023-10-09', NULL, 1),
('C000000008', 5, '2024-07-13', '2024-07-15', NULL, 1),
('C000000009', 5, '2025-01-11', '2025-01-13', NULL, 1),
('C000000010', 5, '2025-05-10', '2025-05-12', NULL, 1),
('C000000001', 6, '2023-05-04', '2023-05-06', NULL, 1),
('C000000002', 6, '2023-11-03', '2023-11-05', NULL, 1),
('C000000003', 6, '2024-05-03', '2024-05-05', NULL, 1),
('C000000004', 6, '2024-10-12', '2024-10-14', NULL, 1),
('C000000005', 6, '2025-04-12', '2025-04-14', NULL, 1),
('C000000006', 7, '2024-04-29', '2024-05-01', NULL, 1),
('C000000007', 7, '2024-08-17', '2024-08-19', NULL, 1),
('C000000008', 7, '2025-02-22', '2025-02-24', NULL, 1),
('C000000009', 8, '2023-09-23', '2023-09-25', NULL, 1),
('C000000010', 8, '2024-07-20', '2024-07-22', NULL, 1),
('C000000001', 8, '2025-05-17', '2025-05-19', NULL, 1),
('C000000002', 9, '2024-04-06', '2024-04-08', NULL, 1),
('C000000003', 9, '2024-06-29', '2024-07-01', NULL, 1),
('C000000004', 9, '2024-09-14', '2024-09-16', NULL, 1),
('C000000005', 9, '2025-03-29', '2025-03-31', NULL, 1),
('C000000006', 9, '2025-05-03', '2025-05-05', NULL, 1),
('C000000007', 10, '2023-07-08', '2023-07-10', NULL, 1),
('C000000008', 10, '2024-12-28', '2024-12-30', NULL, 1),
('C000000009', 11, '2023-10-28', '2023-10-30', NULL, 1),
('C000000010', 11, '2024-11-02', '2024-11-04', NULL, 1),
('C000000001', 11, '2025-04-19', '2025-04-21', NULL, 1),
('C000000002', 12, '2024-05-04', '2024-05-06', NULL, 1),
('C000000003', 12, '2025-05-04', '2025-05-06', NULL, 1),
('C000000004', 13, '2024-07-27', '2024-07-29', NULL, 1),
('C000000005', 13, '2025-05-02', '2025-05-04', NULL, 1),
('C000000006', 14, '2023-06-17', '2023-06-19', NULL, 1),
('C000000007', 14, '2024-06-15', '2024-06-17', NULL, 1),
('C000000008', 14, '2025-04-05', '2025-04-07', NULL, 1),
('C000000009', 15, '2023-04-15', '2023-04-17', NULL, 1),
('C000000010', 15, '2024-04-13', '2024-04-15', NULL, 1),
('C000000001', 15, '2025-03-22', '2025-03-24', NULL, 1),
('C000000002', 16, '2024-08-03', '2024-08-05', NULL, 1),
('C000000003', 16, '2025-04-26', '2025-04-28', NULL, 1),
('C000000004', 17, '2023-07-22', '2023-07-24', NULL, 1),
('C000000005', 17, '2024-07-06', '2024-07-08', NULL, 1),
('C000000006', 17, '2025-05-10', '2025-05-12', NULL, 1),
('C000000007', 18, '2024-09-07', '2024-09-09', NULL, 1),
('C000000008', 18, '2025-05-17', '2025-05-19', NULL, 1),
('C000000009', 19, '2024-06-08', '2024-06-10', NULL, 1),
('C000000010', 19, '2025-03-08', '2025-03-10', NULL, 1),
('C000000001', 20, '2024-07-14', '2024-07-16', NULL, 1),
('C000000002', 20, '2025-04-28', '2025-04-30', NULL, 1),
('C000000003', 21, '2024-11-23', '2024-11-25', NULL, 1),
('C000000004', 21, '2025-04-29', '2025-05-01', NULL, 1),
('C000000005', 22, '2023-12-09', '2023-12-11', NULL, 1),
('C000000006', 22, '2024-12-14', '2024-12-16', NULL, 1),
('C000000007', 23, '2024-01-13', '2024-01-15', NULL, 1),
('C000000008', 23, '2025-01-18', '2025-01-20', NULL, 1),
('C000000009', 24, '2024-04-20', '2024-04-22', NULL, 1),
('C000000010', 24, '2025-04-20', '2025-04-22', NULL, 1);

-- 以下の4点はレンタル中とする
INSERT INTO rental_histories (customer_code, rental_item_id, rental_date, return_date, memo, has_returned) VALUES
('C000000001', 1, '2026-05-20', '2026-06-03', NULL, 0),
('C000000002', 2, '2026-05-21', '2026-06-04', NULL, 0),
('C000000003', 9, '2026-05-22', '2026-06-05', NULL, 0),
('C000000004', 21, '2026-05-23', '2026-06-06', NULL, 0);
