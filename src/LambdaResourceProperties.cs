using System;

namespace Cloudformation4dotNET.Lambda
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class LambdaResourceProperties : Attribute
    {

        public int TimeoutInSeconds { get; set; } = 20;

        public int Concurrency { get; set; } = -1;

        /// <summary>
        /// VPCSecurityGroupIdsRef and VPCSubnetIdsRef are required if you want your Lambda to access VPC.
        /// Setting those values will add:
        /// VpcConfig:
        ///     SecurityGroupIds: !Ref VPCSecurityGroupIdsParameterName <= List<AWS::EC2::SecurityGroup::Id>
        ///     SubnetIds: !Ref VPCSubnetIdsParameterName <= List<AWS::EC2::Subnet::Id>
        /// </summary>
        public string VPCSecurityGroupIdsParameterName { get; set; } = "";

        // In case you want to use a single Security Group.
        // ...  SecurityGroupIds: 
        //          - !Ref VPCSecurityGroup <= AWS::EC2::SecurityGroup::Id
        public string VPCSecurityGroup { get; set; } = "";

        /// <summary>
        /// VPCSecurityGroupIdsRef and VPCSubnetIdsRef are required if you want your Lambda to access VPC.
        /// Setting those values will add:
        /// VpcConfig:
        ///     SecurityGroupIds: !Ref VPCSecurityGroupIdsParameterName <= List<AWS::EC2::SecurityGroup::Id>
        ///     SubnetIds: !Ref VPCSubnetIdsParameterName <= List<AWS::EC2::Subnet::Id>
        /// </summary>
        public string VPCSubnetIdsParameterName { get; set; } = "";

        // In case you just want to use a single VPC Subnet.
        // ...  SubnetIds:
        //          - !Ref VPCSubnet <= AWS::EC2::Subnet::Id
        public string VPCSubnet { get; set; } = "";


    }
}
