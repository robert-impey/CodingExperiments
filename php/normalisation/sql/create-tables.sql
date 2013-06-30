-- Creates the tables
-- (c) 2010-03-05, Robert Impey

CREATE TABLE denormalised_swimming_sessions (
	id INTEGER(8) NOT NULL AUTO_INCREMENT PRIMARY KEY,
	session_date DATE NOT NULL,
	number_of_lengths INT(3) NOT NULL,
	first_name VARCHAR(255) NOT NULL,
	last_name VARCHAR(255) NOT NULL,
	swimming_pool VARCHAR(255) NOT NULL,
	swimming_pool_length INTEGER(3) NOT NULL
) ENGINE = InnoDB;

CREATE TABLE swimmers (
	id INTEGER(8) NOT NULL AUTO_INCREMENT PRIMARY KEY,
	first_name VARCHAR(255) NOT NULL,
	last_name VARCHAR(255) NOT NULL
) ENGINE = InnoDB;

ALTER TABLE swimmers ADD UNIQUE full_name (
	first_name,
	last_name
);

CREATE TABLE swimming_pools (
	id INTEGER(8) NOT NULL AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(255) NOT NULL,
	swimming_pool_length INTEGER(3) NOT NULL
) ENGINE = InnoDB;

ALTER TABLE swimming_pools ADD UNIQUE (
	name
);

CREATE TABLE swimming_sessions (
	id INTEGER(8) NOT NULL AUTO_INCREMENT PRIMARY KEY,
	session_date DATE NOT NULL,
	number_of_lengths INT(3) NOT NULL,
	swimmer_id INTEGER(8) NOT NULL REFERENCES swimmers(id) MATCH FULL ON DELETE CASCADE,
	swimming_pool_id INTEGER(8) NOT NULL REFERENCES swimming_pools(id) MATCH FULL ON DELETE CASCADE
) ENGINE = InnoDB;
