CREATE DATABASE name_list CHARACTER SET utf8;
GRANT ALL ON name_list.* TO develop@'%' IDENTIFIED BY 'develop';

USE name_list;
CREATE TABLE users(id INTEGER PRIMARY KEY AUTO_INCREMENT, last_name VARCHAR(32), first_name VARCHAR(32));

INSERT INTO users(last_name, first_name) VALUES("AAA", "AAA");
INSERT INTO users(last_name, first_name) VALUES("BBB", "BBB");
INSERT INTO users(last_name, first_name) VALUES("CCC", "CCC");
