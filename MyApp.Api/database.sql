CREATE TABLE users(
    id BIGINT NOT NULL PRIMARY KEY,
    first_name VARCHAR(64) NOT NULL,
    last_name VARCHAR(64) NOT NULL,
    email VARCHAR(128) NOT NULL
)

CREATE TABLE spendings (
    id BIGINT NOT NULL PRIMARY KEY,
    price INT NOT NULL,
    created_at DATETIME2 DEFAULT GETDATE(),
    user_id BIGINT NOT NULL,

    CONSTRAINT user_id_fk FOREIGN KEY (user_id) REFERENCES users (id)
)