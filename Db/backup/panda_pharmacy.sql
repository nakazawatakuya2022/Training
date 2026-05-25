-- データベース作成
IF NOT EXISTS (
    SELECT name 
    FROM master.dbo.sysdatabases 
    WHERE name = 'PandaPharmacy'
)
BEGIN
    CREATE DATABASE PandaPharmacy;
END
GO

USE PandaPharmacy
GO

-- ユーザアカウントテーブル
-- * BackupToTempTable
DROP TABLE IF EXISTS users;

-- * RestoreFromTempTable
CREATE TABLE users (
  user_name char(6) NOT NULL
  , password varchar(20) NOT NULL
  , first_name nvarchar(20) NOT NULL
  , last_name nvarchar(20) NOT NULL
  , role tinyint NOT NULL
  , CONSTRAINT users_PKC PRIMARY KEY (user_name)
) ;

-- 注文テーブル
-- * BackupToTempTable
DROP TABLE IF EXISTS orders;

-- * RestoreFromTempTable
CREATE TABLE orders (
  order_id int identity NOT NULL
  , order_date date NOT NULL
  , customer_no char(6) NOT NULL
  , product_id int NOT NULL
  , quantity int NOT NULL
  , CONSTRAINT orders_PKC PRIMARY KEY (order_id)
) ;

-- 顧客テーブル
-- * BackupToTempTable
DROP TABLE IF EXISTS customers;

-- * RestoreFromTempTable
CREATE TABLE customers (
  customer_no char(6) NOT NULL
  , customer_name nvarchar(50) NOT NULL
  , customer_kana nvarchar(50)
  , email varchar(100)
  , tel varchar(20)
  , customer_rank char(1)
  , CONSTRAINT customers_PKC PRIMARY KEY (customer_no)
) ;

-- 商品テーブル
-- * BackupToTempTable
DROP TABLE IF EXISTS products;

-- * RestoreFromTempTable
CREATE TABLE products (
  product_id int identity NOT NULL
  , product_name nvarchar(50) NOT NULL
  , price int NOT NULL
  , memo nvarchar(200)
  , category_id int NOT NULL
  , CONSTRAINT products_PKC PRIMARY KEY (product_id)
) ;

-- カテゴリテーブル
-- * BackupToTempTable
DROP TABLE IF EXISTS categories;

-- * RestoreFromTempTable
CREATE TABLE categories (
  category_id int identity NOT NULL
  , category_name nvarchar(50) NOT NULL
  , CONSTRAINT categories_PKC PRIMARY KEY (category_id)
) ;

EXECUTE sp_addextendedproperty N'MS_Description', N'ユーザアカウントテーブル', N'SCHEMA', N'dbo', N'TABLE', N'users', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'ユーザ名', N'SCHEMA', N'dbo', N'TABLE', N'users', N'COLUMN', N'user_name';
EXECUTE sp_addextendedproperty N'MS_Description', N'パスワード', N'SCHEMA', N'dbo', N'TABLE', N'users', N'COLUMN', N'password';
EXECUTE sp_addextendedproperty N'MS_Description', N'名', N'SCHEMA', N'dbo', N'TABLE', N'users', N'COLUMN', N'first_name';
EXECUTE sp_addextendedproperty N'MS_Description', N'氏', N'SCHEMA', N'dbo', N'TABLE', N'users', N'COLUMN', N'last_name';
EXECUTE sp_addextendedproperty N'MS_Description', N'役割', N'SCHEMA', N'dbo', N'TABLE', N'users', N'COLUMN', N'role';

EXECUTE sp_addextendedproperty N'MS_Description', N'注文テーブル', N'SCHEMA', N'dbo', N'TABLE', N'orders', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'注文ID', N'SCHEMA', N'dbo', N'TABLE', N'orders', N'COLUMN', N'order_id';
EXECUTE sp_addextendedproperty N'MS_Description', N'注文日', N'SCHEMA', N'dbo', N'TABLE', N'orders', N'COLUMN', N'order_date';
EXECUTE sp_addextendedproperty N'MS_Description', N'顧客番号', N'SCHEMA', N'dbo', N'TABLE', N'orders', N'COLUMN', N'customer_no';
EXECUTE sp_addextendedproperty N'MS_Description', N'商品ID', N'SCHEMA', N'dbo', N'TABLE', N'orders', N'COLUMN', N'product_id';
EXECUTE sp_addextendedproperty N'MS_Description', N'数量', N'SCHEMA', N'dbo', N'TABLE', N'orders', N'COLUMN', N'quantity';

EXECUTE sp_addextendedproperty N'MS_Description', N'顧客テーブル', N'SCHEMA', N'dbo', N'TABLE', N'customers', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'顧客番号', N'SCHEMA', N'dbo', N'TABLE', N'customers', N'COLUMN', N'customer_no';
EXECUTE sp_addextendedproperty N'MS_Description', N'顧客名', N'SCHEMA', N'dbo', N'TABLE', N'customers', N'COLUMN', N'customer_name';
EXECUTE sp_addextendedproperty N'MS_Description', N'顧客カナ', N'SCHEMA', N'dbo', N'TABLE', N'customers', N'COLUMN', N'customer_kana';
EXECUTE sp_addextendedproperty N'MS_Description', N'Email', N'SCHEMA', N'dbo', N'TABLE', N'customers', N'COLUMN', N'email';
EXECUTE sp_addextendedproperty N'MS_Description', N'TEL', N'SCHEMA', N'dbo', N'TABLE', N'customers', N'COLUMN', N'tel';
EXECUTE sp_addextendedproperty N'MS_Description', N'顧客ランク', N'SCHEMA', N'dbo', N'TABLE', N'customers', N'COLUMN', N'customer_rank';

EXECUTE sp_addextendedproperty N'MS_Description', N'商品テーブル', N'SCHEMA', N'dbo', N'TABLE', N'products', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'商品ID', N'SCHEMA', N'dbo', N'TABLE', N'products', N'COLUMN', N'product_id';
EXECUTE sp_addextendedproperty N'MS_Description', N'商品名', N'SCHEMA', N'dbo', N'TABLE', N'products', N'COLUMN', N'product_name';
EXECUTE sp_addextendedproperty N'MS_Description', N'価格', N'SCHEMA', N'dbo', N'TABLE', N'products', N'COLUMN', N'price';
EXECUTE sp_addextendedproperty N'MS_Description', N'説明文', N'SCHEMA', N'dbo', N'TABLE', N'products', N'COLUMN', N'memo';
EXECUTE sp_addextendedproperty N'MS_Description', N'カテゴリID', N'SCHEMA', N'dbo', N'TABLE', N'products', N'COLUMN', N'category_id';

EXECUTE sp_addextendedproperty N'MS_Description', N'カテゴリテーブル', N'SCHEMA', N'dbo', N'TABLE', N'categories', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'カテゴリID', N'SCHEMA', N'dbo', N'TABLE', N'categories', N'COLUMN', N'category_id';
EXECUTE sp_addextendedproperty N'MS_Description', N'カテゴリ名', N'SCHEMA', N'dbo', N'TABLE', N'categories', N'COLUMN', N'category_name';

INSERT INTO customers VALUES ('000001', '山田太郎', 'やまだたろう', 'yamada@example.com', '090-0034-5678', 'S')
INSERT INTO customers VALUES ('000002', '鈴木次郎', 'すずきじろう', 'suzuki@example.com', '080-0145-6789', 'B')
INSERT INTO customers VALUES ('000003', '田中花子', 'たなかはなこ', 'tanaka@example.com', '070-0256-7890', 'C')
INSERT INTO customers VALUES ('000004', '佐藤健太', 'さとうけんた', 'sato@example.com', '080-0311-2222', 'A')
INSERT INTO customers VALUES ('000005', '高橋美佳', 'たかはしみか', 'takahashi@example.com', '090-0322-3333', 'B')
INSERT INTO customers VALUES ('000006', '中村隆太', 'なかむらりゅうた', 'nakamura@example.com', '080-0433-4444', 'C')
INSERT INTO customers VALUES ('000007', '三浦さちこ', 'みうらさちこ', 'miura@example.com', '090-0644-5555', 'A')
INSERT INTO customers VALUES ('000008', '渡辺一郎', 'わたなべいちろう', 'watanabe@example.com', '080-0855-6666', 'B')
INSERT INTO customers VALUES ('000009', '山口恵美', 'やまぐちえみ', 'yamaguchi@example.com', '070-0966-7777', 'C')
INSERT INTO customers VALUES ('000010', '斉藤拓也', 'さいとうたくや', 'saito@example.com', '090-0177-8888', 'A')
INSERT INTO customers VALUES ('000011', '中村結衣', 'なかむらゆい', 'nakamura@example.com', '090-5566-7788', 'C');
INSERT INTO customers VALUES ('000012', '田中悠太', 'たなかゆうた', 'tanaka@example.com', '080-6677-8899', 'A');

INSERT INTO categories (category_name) VALUES ('薬品')
INSERT INTO categories (category_name) VALUES ('化粧品')
INSERT INTO categories (category_name) VALUES ('サプリメント')
INSERT INTO categories (category_name) VALUES ('スキンケア')
INSERT INTO categories (category_name) VALUES ('食品')

INSERT INTO products (product_name, price, memo, category_id) VALUES ('シンドロール', 980, '解熱鎮痛薬です。頭痛、肩こり、腰痛などの痛みに効果的です。', 1)
INSERT INTO products (product_name, price, memo, category_id) VALUES ('パススタット', 680, '頭痛、肩こり、腰痛などの痛みに効果的な鎮痛剤です。', 1)
INSERT INTO products (product_name, price, memo, category_id) VALUES ('アイソレーブ', 1280, '炎症止めと鎮痛作用のある薬です。痛みや炎症をやわらげる効果があります。', 1)
INSERT INTO products (product_name, price, memo, category_id) VALUES ('マスカラ', 1980, 'まつげを長く、ボリュームアップさせるマスカラです。', 2)
INSERT INTO products (product_name, price, memo, category_id) VALUES ('リップスティック', 1280, '唇に色とツヤを与える口紅です。', 2)
INSERT INTO products (product_name, price, memo, category_id) VALUES ('フェイスパウダー', 1680, '肌のテカリを抑え、メイクの仕上げに使うフェイスパウダーです。', 2)
INSERT INTO products (product_name, price, memo, category_id) VALUES ('プロテインパウダー', 2980, '筋肉量の増加や回復をサポートするプロテインパウダーです。', 3)
INSERT INTO products (product_name, price, memo, category_id) VALUES ('マルチビタミン', 1380, NULL, 3)
INSERT INTO products (product_name, price, memo, category_id) VALUES ('グリーンオメガ', 2980, '健康的な脂肪酸を摂取できるサプリメントです。', 3)
INSERT INTO products (product_name, price, memo, category_id) VALUES ('化粧水', 980, NULL, 4)

INSERT INTO orders (order_date, customer_no, product_id, quantity) VALUES
('2024-03-01', '000001', 1, 5),
('2024-03-02', '000002', 2, 3),
('2024-03-03', '000007', 1, 8),
('2024-03-04', '000006', 6, 2),
('2024-03-05', '000003', 5, 1),
('2024-03-06', '000006', 6, 6),
('2024-03-07', '000007', 5, 7),
('2024-03-08', '000001', 8, 4),
('2024-03-09', '000009', 6, 2),
('2024-03-10', '000010', 10, 5),
('2024-03-11', '000003', 1, 3),
('2024-03-12', '000005', 2, 6),
('2024-03-13', '000001', 3, 4),
('2024-03-14', '000010', 4, 8),
('2024-03-15', '000006', 3, 2),
('2024-03-16', '000008', 10, 1),
('2024-03-17', '000002', 7, 5),
('2024-03-18', '000009', 4, 3),
('2024-03-19', '000007', 9, 7),
('2024-03-20', '000004', 5, 4),
('2024-03-21', '000010', 1, 2),
('2024-03-22', '000002', 4, 5),
('2024-03-23', '000007', 2, 1),
('2024-03-24', '000004', 6, 9),
('2024-03-25', '000007', 5, 3),
('2024-03-26', '000001', 3, 4),
('2024-03-27', '000006', 8, 6),
('2024-03-28', '000003', 8, 2),
('2024-03-29', '000008', 9, 5),
('2024-03-30', '000005', 10, 10),
('2024-04-01', '000001', 2, 5),
('2024-04-02', '000002', 3, 3),
('2024-04-03', '000003', 4, 10),
('2024-04-04', '000004', 5, 2),
('2024-04-05', '000005', 6, 1),
('2024-04-06', '000006', 7, 6),
('2024-04-07', '000007', 8, 8),
('2024-04-08', '000008', 9, 4),
('2024-04-09', '000009', 10, 2),
('2024-04-10', '000010', 1, 7),
('2024-04-11', '000001', 3, 5),
('2024-04-12', '000002', 4, 3),
('2024-04-13', '000003', 5, 10),
('2024-04-14', '000004', 6, 2),
('2024-04-15', '000005', 7, 1),
('2024-04-16', '000006', 8, 6),
('2024-04-17', '000007', 9, 8),
('2024-04-18', '000008', 10, 4),
('2024-04-19', '000009', 1, 2),
('2024-04-20', '000010', 2, 7),
('2024-04-21', '000001', 4, 5),
('2024-04-22', '000002', 5, 3),
('2024-04-23', '000003', 6, 10),
('2024-04-24', '000004', 7, 2),
('2024-04-25', '000005', 8, 1),
('2024-04-26', '000006', 9, 6),
('2024-04-27', '000007', 10, 8),
('2024-04-28', '000008', 1, 4),
('2024-04-29', '000009', 2, 2),
('2024-04-30', '000010', 3, 7),
('2024-05-01', '000001', 1, 1),
('2024-05-02', '000001', 4, 2),
('2024-05-03', '000001', 7, 3),
('2024-05-04', '000004', 7, 2),
('2024-05-05', '000005', 8, 1),
('2024-05-05', '000005', 1, 3),
('2024-05-06', '000006', 9, 6),
('2024-05-08', '000012', 5, 4);

INSERT INTO users (user_name, password, first_name, last_name, role) VALUES ('100001', 'password1', 'Taro', 'Yamada', 0);
INSERT INTO users (user_name, password, first_name, last_name, role) VALUES ('100002', 'password2', 'Hanako', 'Sato', 0);
INSERT INTO users (user_name, password, first_name, last_name, role) VALUES ('100003', 'password3', 'Ichiro', 'Tanaka', 1);
INSERT INTO users (user_name, password, first_name, last_name, role) VALUES ('100004', 'password4', 'Sakura', 'Suzuki', 0);
INSERT INTO users (user_name, password, first_name, last_name, role) VALUES ('100005', 'password5', 'Jiro', 'Takahashi', 0);
