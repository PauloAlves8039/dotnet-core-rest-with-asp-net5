FROM mysql:5.7.22
EXPOSE 3306
COPY ./src/RestWithASP-NET5.API/db/migrations/ /home/database/
COPY ./src/RestWithASP-NET5.API/db/dataset/ /home/database/
COPY ./src/RestWithASP-NET5.API/ci/init_database.sh/ /docker-entrypoint-initdb.d/init_database.sh