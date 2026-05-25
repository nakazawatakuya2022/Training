INSERT INTO 
	products (product_name, price, memo, category_id) 
VALUES
	('ワセリン', 398, 'ハンドクリームより強力！乾燥から肌を守ります。', 3);

INSERT INTO 
	products
VALUES
	('ビタミナC', 1980, '1粒でレモン30個分のビタミンC。', 4);

SELECT * FROM products

SELECT * FROM products
WHERE product_id IN(11,12);

INSERT INTO products (product_name, price, category_id) 
VALUES ('アイシャドウ', 1180,2);

INSERT INTO products (product_name, price, memo, category_id) 
VALUES ('リップグロス', 780, NULL, 2);

INSERT INTO products (product_name, price, memo, category_id) 
VALUES
('ドリームハーモニザー', 398, '安眠をサポートする睡眠調整薬。', 1),
('クレンジング', 780, 'メイクや汚れを強力に落とす！', 2),
('アイガード', 580, '目の疲れやストレスから保護。',4);

UPDATE products
SET
	product_name = 'すごい化粧水',
	price = 1200,
	memo = 'かなりすごい化粧水'
WHERE product_id = 10;

UPDATE products 
SET
price = price + 100
WHERE category_id = 1;

DELETE FROM categories WHERE category_id = 11;


SELECT * FROM products ORDER BY category_id DESC, price ASC;

SELECT
	category_id,
	COUNT(*) AS カテゴリ別の商品数,
	SUM(price) AS カテゴリ別の合計金額
FROM
	products
GROUP BY
	category_id
HAVING
	SUM(price) > 6000;

SELECT
	product_name,
	price,
	products.category_id,
	category_name
FROM
	products
	INNER JOIN categories
	ON products.category_id = categories.category_id

SELECT
	product_name,
	price,
	p.category_id,
	category_name
	
FROM
	products AS p
	LEFT JOIN categories AS c
	ON p.category_id = c.category_id