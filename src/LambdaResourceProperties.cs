using System;

namespace Cloudformation4dotNET.Lambda
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class LambdaResourceProperties : Attribute
    {

        public int TimeoutInSeconds { get; set; } = 20;

        /// <summary>
        /// VPCSecurityGroupIdsRef and VPCSubnetIdsRef are required if you want your Lambda to access VPC.
        /// Setting those values will add:
        /// VpcConfig:
        ///     SecurityGroupIds: !Ref VPCSecurityGroupIdsParameterName
        ///     SubnetIds: !Ref VPCSubnetIdsParameterName
        /// </summary>
        public string VPCSecurityGroupIdsParameterName { get; set; } = "";

        /// <summary>
        /// VPCSecurityGroupIdsRef and VPCSubnetIdsRef are required if you want your Lambda to access VPC.
        /// Setting those values will add:
        /// VpcConfig:
        ///     SecurityGroupIds: !Ref VPCSecurityGroupIdsParameterName
        ///     SubnetIds: !Ref VPCSubnetIdsParameterName
        /// </summary>
        public string VPCSubnetIdsParameterName { get; set; } = "";
    }
}
