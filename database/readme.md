# Database usage

1. Run this:

>docker build -t msbogtest --build-arg sapass=abc .

>docker run -p 5432:5432 --name bggsql -d msbogtest

2. Utils:

>docker logs <container_name>

>docker run -it <image_name> bash

>docker exec -it <container_name> bash

>docker container prune

>docker container inspect <container_name>

3. More info: 

https://hub.docker.com/_/postgres

https://dataschool.com/learn-sql/importing-data-from-csv-in-postgresql/
