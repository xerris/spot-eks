using Amazon.CDK;
using Amazon.CDK.AWS.EC2;
using Amazon.CDK.AWS.EKS;

namespace SpotEKS
{
    public class SpotStack : Stack
    {
        internal SpotStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var cluster = new Cluster(scope, "{id}-cluster", new ClusterProps
            {
                ClusterName = "yoda",
                DefaultCapacity = 0,
            });
            cluster.AddCapacity("{id}-spot-instances", new CapacityOptions
            {
                SpotPrice = "0.004",
                InstanceType =  new InstanceType("t3.large"),
                MaxCapacity = 10,
            });
        }
    }
}
