SELECT P.name, C.name
FROM Product P
LEFT JOIN product_category pc on P.id = pc.product_id
LEFT JOIN Category C on pc.category_id = C.id
