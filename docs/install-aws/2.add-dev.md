# Add new user dev

1. Add new policies

    1.1. **console-store-parameters** policy

    ``` json
    {
        "Version": "2012-10-17",
        "Statement": [
            {
                "Effect": "Allow",
                "Action": [
                    "ssm:PutParameter",
                    "ssm:DeleteParameter",
                    "ssm:GetParameterHistory",
                    "ssm:GetParametersByPath",
                    "ssm:GetParameters",
                    "ssm:GetParameter",
                    "ssm:DeleteParameters"
                ],
                "Resource": "arn:aws:ssm:*:*:parameter/*"
            },
            {
                "Sid": "VisualEditor1",
                "Effect": "Allow",
                "Action": [
                    "ssm:DescribeParameters",
                    "kms:ListAliases"
                ],
                "Resource": "*"
            }
        ]
    }
    ```

    1.2. **get-store-parameters** policy

    ``` json
    {
        "Version": "2012-10-17",
        "Statement": [
            {
                "Action": [
                    "ssm:GetParameter",
                    "ssm:GetParametersByPath"
                ],
                "Resource": "arn:aws:ssm:eu-west-1:610201574913:parameter/*",
                "Effect": "Allow"
            }
        ]
    }
    ```

    1.3. **run-ec2** policy

    ``` json
    {
        "Version": "2012-10-17",
        "Statement": [
            {
                "Effect": "Allow",
                "Action": [
                    "ec2:*",
                    "iam:ListInstanceProfiles"
                ],
                "Resource": "*"
            },
            {
                "Effect": "Allow",
                "Action": [
                    "iam:PassRole"
                ],
                "Resource": "arn:aws:iam::610201574913:role/run-ec2"
            }
        ]
    }
    ```

    1.4. **ssh-ec2** policy

     ``` json
    {
        "Version": "2012-10-17",
        "Statement": [
            {
                "Effect": "Allow",
                "Action": [
                    "ec2-instance-connect:SendSSHPublicKey"
                ],
                "Resource": [
                    "arn:aws:ec2:eu-west-1:610201574913:instance/*"
                ],
                "Condition": {
                    "StringEquals": {
                        "ec2:osuser": "ec2-user"
                    }
                }
            }
        ]
    }
    ```

2. Add new **SsmGrp**, **ConsoleStoreParamsGrp** ,**RunEc2Grp** groups

3. Add new users

    3.1. Add **SSMUser1** user with **Programmatic access** option
to **SsmGrp** group. Also create access key

    3.2. Add **developer1** user to **ConsoleStoreParamsGrp** and **RunEc2Grp** groups and enable MFA

4. Add **run-ec2** role and attach **get-store-parameters** policy
