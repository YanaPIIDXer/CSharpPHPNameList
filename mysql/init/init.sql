CREATE DATABASE name_list CHARACTER SET utf8;
GRANT ALL ON name_list.* TO develop@'%' IDENTIFIED BY 'develop';

USE name_list;
CREATE TABLE users(id INTEGER PRIMARY KEY AUTO_INCREMENT, last_name VARCHAR(32), first_name VARCHAR(32));
