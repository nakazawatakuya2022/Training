SELECT 
	customer_no, 
	customer_name 
FROM 
	customers;

SELECT
	* 
FROM 
	customers;

SELECT
	customer_no AS 顧客番号,
	customer_name AS 顧客名
FROM
	customers;

SELECT '桜町駅前店'　AS shop,
	*
FROM orders;

SELECT price AS '元の価格',
		price * 2 AS '２倍の価格'
FROM products;

SELECT * FROM products WHERE category_id = 2;

SELECT * FROM products WHERE product_id IN (1, 2, 3);

SELECT * FROM products WHERE product_id 

NOT IN (1, 2, 3);

SELECT * FROM products WHERE memo LIKE '%頭痛%';