SELECT
    o.order_id AS "注文ID",
    o.order_date AS "注文日",
    o.customer_no AS "顧客番号",
    p.product_name AS "商品名",
    p.price AS "価格",
    o.quantity AS "数量",
    p.price * o.quantity AS "合計金額"
FROM
    orders AS o
    JOIN products AS p
        ON p.product_id = o.product_id

ORDER BY
    o.order_date ASC;