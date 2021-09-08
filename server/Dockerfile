FROM php:7.3-apache

RUN apt-get update && \
    docker-php-ext-install pdo_mysql mysqli mbstring

WORKDIR /var/www/html
ADD ./src /var/www/html
