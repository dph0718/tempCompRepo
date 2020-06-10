CREATE TABLE IF NOT EXISTS BreakfastCereals (
    cereal_id int NOT NULL AUTO_INCREMENT,
    name VARCHAR(30),
	manufacturer VARCHAR(30),
	calories_per_serving INT,
    fiber INT,
	sugar INT,
	price FLOAT,
	hasCartoonMascot BOOL,
    PRIMARY KEY (cereal_id)
);