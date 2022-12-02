-- Note that FK creation has been skipped due to example simplification

-- SEED CATEGORY 
CREATE TABLE CATEGORY (
                          ID INTEGER PRIMARY KEY,
                          NAME TEXT NOT NULL
);
INSERT INTO CATEGORY VALUES (1, 'Category A');
INSERT INTO CATEGORY VALUES (2, 'Category B');
INSERT INTO CATEGORY VALUES (3, 'Category C');


-- SEED PRODUCT
CREATE TABLE PRODUCT (
                         ID INTEGER PRIMARY KEY,
                         NAME TEXT NOT NULL
);

INSERT INTO PRODUCT VALUES (1, 'Product A1');
INSERT INTO PRODUCT VALUES (2, 'Product A2');
INSERT INTO PRODUCT VALUES (3, 'Product B1');
INSERT INTO PRODUCT VALUES (4, 'Product C1');
INSERT INTO PRODUCT VALUES (5, 'Product without category');

-- SEED CONJUNCTION
CREATE TABLE PRODUCT_X_CATEGORY (
                                    ID INTEGER PRIMARY KEY,
                                    PRODUCT_ID INTEGER,
                                    CATEGORY_ID INTEGER
);

INSERT INTO PRODUCT_X_CATEGORY VALUES (1, 1, 1);
INSERT INTO PRODUCT_X_CATEGORY VALUES (2, 2, 1);
INSERT INTO PRODUCT_X_CATEGORY VALUES (3, 3, 2);
INSERT INTO PRODUCT_X_CATEGORY VALUES (4, 4, 3);

-- Test query
SELECT
    P.NAME AS PRODUCT_NAME,
    C.NAME AS CATEGORY
FROM PRODUCT P
         LEFT JOIN PRODUCT_X_CATEGORY PC ON P.ID = PC.PRODUCT_ID
         LEFT JOIN CATEGORY C ON C.ID = PC.CATEGORY_ID

/*
Output:
-------
Product A1 | Category A
Product A2 | Category A
Product B1 | Category B
Product C1 | Category C
Product without category | null
*/