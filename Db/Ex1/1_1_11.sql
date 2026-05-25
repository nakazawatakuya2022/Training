SELECT
	product_id AS"商品ID",
	product_name AS "商品名",
	price AS "価格",
	memo AS "説明文"
FROM products
WHERE memo IS NULL;
