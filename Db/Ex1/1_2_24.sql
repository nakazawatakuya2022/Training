SELECT
	product_id AS "商品ID",
	product_name AS "商品名",
	c.category_name AS "カテゴリー名",
	price AS "価格",
	memo AS "説明文"

FROM
	products AS p
	JOIN categories AS c
	ON p.category_id = c.category_id

WHERE
	 c.category_name NOT LIKE '%薬品%';
	
