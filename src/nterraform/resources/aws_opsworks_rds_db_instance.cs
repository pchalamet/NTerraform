using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_opsworks_rds_db_instance")]
    public sealed class aws_opsworks_rds_db_instance : nterraform.resource
    {
        public aws_opsworks_rds_db_instance(string @dbPassword,
                                            string @dbUser,
                                            string @rdsDbInstanceArn,
                                            string @stackId)
        {
            @DbPassword = @dbPassword;
            @DbUser = @dbUser;
            @RdsDbInstanceArn = @rdsDbInstanceArn;
            @StackId = @stackId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "db_password", @out: false, min: 1, max: 1)]
        public string @DbPassword { get; }

        [nterraform.TerraformProperty(name: "db_user", @out: false, min: 1, max: 1)]
        public string @DbUser { get; }

        [nterraform.TerraformProperty(name: "rds_db_instance_arn", @out: false, min: 1, max: 1)]
        public string @RdsDbInstanceArn { get; }

        [nterraform.TerraformProperty(name: "stack_id", @out: false, min: 1, max: 1)]
        public string @StackId { get; }
    }

}
