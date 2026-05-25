SELECT
    customer_no AS "顧客番号",
    COUNT(order_id) AS "注文総件数",
    SUM(quantity) AS "数量の合計"
FROM
    orders

GROUP BY
    customer_no;