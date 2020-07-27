# Docker: .net core & ms sql

1. Run local

    1.1. locate docker-compose.yml

    1.2. run(cmd)
    > docker-compose build
    > docker-compose up

2. if you want to install it on aws:

    2.1. <https://hub.docker.com/r/flashm01/test1coredb>

    2.2. ssh to instance and run:
    > docker pull flashm01/test1coredb:db
    > docker pull flashm01/test1coredb:api

    2.3. run images:
    >docker run -p 1433:1433 -d flashm01/test1coredb:db

    >docker run -p 80:80 -p 443:443 -d flashm01/test1coredb:api

3. [Modify an image and create another one:](#modify-image)

    >docker run -p 5432:5432 -d old-img

    >docker commit --change "ENV POSTGRES_USER=u1 POSTGRES_PASSWORD=p1" c5e new-img

    >docker run -p 5432:5432 -d new-img

    >check if ok: printenv