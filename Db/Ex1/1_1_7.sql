SELECT
    product_id AS "商品ID",
    product_name AS "商品名",
    price AS "価格"
FROM products
WHERE product_id IN (1,4,8);