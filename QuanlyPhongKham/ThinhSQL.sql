CREATE EXTENSION IF NOT EXISTS "uuid-ossp";
CREATE TABLE Users (
    Id TEXT PRIMARY KEY,
    UserName TEXT NOT NULL,
    Password TEXT,
    Email TEXT,
    Role INTEGER
);

SELECT *FROM Users