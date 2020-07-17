CREATE TABLE Products (ID int, ProductName varchar(200));

COPY Products (ID,ProductName) 
FROM '/docker-entrypoint-initdb.d/products.csv' DELIMITER ',' CSV;