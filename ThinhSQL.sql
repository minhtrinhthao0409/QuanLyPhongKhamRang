CREATE EXTENSION IF NOT EXISTS "uuid-ossp";
CREATE TABLE Users (
    id UUID NOT NULL DEFAULT uuid_generate_v4() PRIMARY KEY,
    username VARCHAR(255) NOT NULL,
    passwords VARCHAR(255) NULL,
    email VARCHAR(255) NULL
);
SELECT *FROM Users