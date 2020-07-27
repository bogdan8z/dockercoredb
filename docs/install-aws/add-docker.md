# Install docker on aws

1. Create [**AWS Free tier**](https://aws.amazon.com/free/?all-free-tier.sort-by=item.additionalFields.SortRank&all-free-tier.sort-order=asc) account

    1.1. create an **adminintrator** user, create a **developer** user to use with ec2. [more info](https://github.com/bogdan8z/dockercoredb/blob/master/README.md#howto-modify-an-image-and-create-another-one)

2. **launch instance** linux2 with .net core

3. connect to the instance with **ec2-user** user

4. install docker:
    4.1. run in ssh:> **sudo su**

    4.2. run in ssh:> **yum update -y**

    4.3. run in ssh:> **amazon-linux-extras install docker**

5. start docker:
    5.1. run in ssh:> **service docker start**

    5.2. run in ssh:> **usermod -a -G docker ec2-user**

6. check if ok
    6.1. relogin with **ec2-user**

    6.2. run in ssh:> **docker info**

7. pull wanted images
    7.1. run in ssh:> **docker pull flashm01/test1coredb:db**

    7.2. run in ssh:> **docker pull flashm01/test1coredb:api**

    here you need to modify the image in order to change user/pass for the database, [more info](https://github.com/bogdan8z/dockercoredb/blob/master/README.md#modify-image)

8. run docker images

    8.1.run in ssh:> **docker run -p 5432:5432 --name bggsql -d newdb**

    8.2. run in ssh:> **docker run -p 80:80 -p 443:443 --name bggapi -d flashm01/test1coredb:api**

9. after every restart you need to start docker:

    * 4.1
    * 5.1
    * 6.1
