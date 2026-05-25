SELECT
    category_id AS "カテゴリID",
    COUNT(memo) AS "商品数"
FROM
    products
GROUP BY
    category_id;


SELECT
    category_id,
    product_name
FROM 
    products
GROUP BY 
    category_id;