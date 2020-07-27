# Docker(aws): .net core & postgres

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

    >check if ok: printenv


## Links

<https://docs.aws.amazon.com/IAM/latest/UserGuide/getting-started_create-admin-group.html>

[install docker***](https://docs.aws.amazon.com/AmazonECS/latest/developerguide/docker-basics.html)

[launch Amazon Linux 2 AMI](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/launching-instance.html)

[connect to linux instance](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AccessingInstances.html)

[docker image to aws](https://reflectoring.io/aws-deploy-docker-image-via-web-console)

<https://expeditedsecurity.com/aws-in-plain-english/>

<https://aws.amazon.com/docker/>

[ecs link1](https://docs.aws.amazon.com/AmazonECS/latest/developerguide/Welcome.html)

[ecs link2](https://eu-central-1.console.aws.amazon.com/ecs/home?region=eu-central-1#/getStarted)

[ecs task](https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definitions.html)

<https://levi9.udemy.com/course/aws-certified-solutions-architect-associate-saa-c02/learn/lecture>

<https://expeditedsecurity.com/aws-in-plain-english/>

[ecs using fargate tutorial](https://docs.aws.amazon.com/AmazonECS/latest/developerguide/getting-started-fargate.html)

[intro load balancer](https://docs.aws.amazon.com/elasticloadbalancing/latest/application/introduction.html)

[deploy container on aws](https://aws.amazon.com/getting-started/hands-on/deploy-docker-containers)

[The AWS Journey Part 1: Deploying Your First Docker Image](https://reflectoring.io/aws-deploy-docker-image-via-web-console)