﻿using System;
using Models;
using Newtonsoft.Json;

namespace Elevator.Api.Dto
{
    [JsonObject]
    public class CreateBuildStepRequestDto
    {
        public string Name { get; set; }
        public Guid BuildConfigId { get; set; }
        public BuildStepScript BuildStepScript { get; set; }
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}\n" +
                   $"{nameof(BuildStepScript)} : {BuildStepScript}";
        }
    }
}
