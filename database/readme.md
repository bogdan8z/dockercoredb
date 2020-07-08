# Run tihs:
>docker build -t msbogtest --build-arg sapass=Test@UZzuYXb2iSnzwk .
>docker run -p 1433:1433 --name bggsql -d msbogtest

# Utils:
>docker logs <container_name>
>docker run -it <image_name> bash
>docker exec -it <container_name> bash
>docker container prune
>docker container inspect <container_name>


# More info: 
https://hub.docker.com/_/microsoft-mssql-server
https://github.com/twright-msft/mssql-node-docker-demo-app