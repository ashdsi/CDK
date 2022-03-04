﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.CDK;

namespace EbInitialInfra
{
    internal interface IAStackProps : IStackProps
    {
        public string EnvironmentName { get; set; }

        public string StageName { get; set; }

        public string VpcName { get; set; }
    }
}
