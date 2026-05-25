SELECT
    category_id AS "カテゴリID",
    COUNT( category_id) AS "登録件数",
    SUM(price) AS "価格の合計"
   
FROM products

GROUP BY category_id;

SELECT
    *
FROM
    order_archives;