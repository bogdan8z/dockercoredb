# Docker(aws): .net core & postgres

This project will create a docker image containing a simple API (.net core) that connects to a postgres database.



1. Run locally

    1.1. locate **docker-compose.yml** file

    1.2. in that folder run(cmd)
    > docker-compose build

    > docker-compose up

2. if you want to run it on aws:

    2.1. [Howto install docker on aws](https://github.com/bogdan8z/dockercoredb/tree/master/docs/install-aws)

    2.3. ssh to instance and run*:
    > docker pull flashm01/test1coredb:db

    > docker pull flashm01/test1coredb:api

    *[check these images on docker hub](https://hub.docker.com/r/flashm01/test1coredb)

    2.4. run images:
    >docker run -p 1433:1433 -d flashm01/test1coredb:db
    
    >docker run -p 80:80 -p 443:443 -d flashm01/test1coredb:api

## Howto modify an image and create another one

    >docker run -p 5432:5432 -d old-img

    >docker commit --change "ENV POSTGRES_USER=u1 POSTGRES_PASSWORD=p1" c5e new-img

    >docker run -p 5432:5432 -d new-img

    >check if ok: printenv | grep POSTGRES_USER

## TODO

1. build or move image to AWS
2. add load balancer
3. finish serverless implementation in AWS
