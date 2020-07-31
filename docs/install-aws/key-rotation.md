# Access key for ec2 instance

1. Be sure you don't have anything set in  **.aws/credentials** and the instance has a **role** attached so overy time you start the instance an **temporary** access key will be assigned.

2. check the current access key

    > aws configure list
