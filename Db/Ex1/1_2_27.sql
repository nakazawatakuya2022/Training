SELECT
    category_id AS "カテゴリID",
    COUNT(*) AS "商品数"
FROM
    products
GROUP BY
    category_id;