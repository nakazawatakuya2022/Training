SELECT *FROM products;

SELECT *FROM categories;

INSERT INTO products
(product_name, price, memo, category_id)
VALUES
(
    'ビタミンエナジー',
    2000,
    '元気をサポートするビタミンが豊富なサプリメントです。',
    3
),
(
    'ネイルケアセラム',
    2980,
    NULL,
    2
),
(
    'イトウの切り餅',
    498,
    NULL,
    5
);