SELECT * FROM products; 
SELECT * FROM order_archives;

SELECT 
	product_id AS "商品ID",
	product_name AS "商品名",
	price AS "価格"
FROM 
	products
ORDER BY price DESC;

SELECT
TOP 3
	order_id AS "注文ID",
	customer_no AS "顧客番号",
	order_date AS "注文日",
	product_id AS "商品ID",
	quantity AS "数量"
FROM 
	order_archives
ORDER BY order_id DESC;