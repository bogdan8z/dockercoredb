# Docker(aws): .net core & postgres

1. Run local

    1.1. locate docker-compose.yml

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

3. [Howto modify an image and create another one:](#modify-image)

    >docker run -p 5432:5432 -d old-img

    >docker commit --change "ENV POSTGRES_USER=u1 POSTGRES_PASSWORD=p1" c5e new-img

    >docker run -p 5432:5432 -d new-img

    >check if ok: printenv

4. Links
todo
