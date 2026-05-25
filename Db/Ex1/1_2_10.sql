SELECT
    COUNT(order_id) AS "注文件数",
    MAX(product_id) AS "最も多かった注文の数",
    MIN(product_id) AS "最も少かった注文の数",
    AVG(product_id) AS "平均注文数"
FROM orders;

SELECT * FROM order_archives;

