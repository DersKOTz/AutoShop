INSERT INTO tovars(picture)
SELECT BulkColumn
FROM OPENROWSET(BULK 'C:\Users\valav\Downloads\Icons\dwburnett-pcoty-roughs-6877-1642525990.jpg', SINGLE_BLOB) AS ImageData;