SELECT * FROM products; 
SELECT * FROM order_archives;

SELECT 
	product_id AS "商品ID",
	product_name AS "商品名",
	price AS "価格"
FROM 
	products
ORDER BY price DESC;

SELECT DISTINCT
	customer_no AS "顧客番号"
FROM 
	order_archives
--ORDER BY order_id DESC;