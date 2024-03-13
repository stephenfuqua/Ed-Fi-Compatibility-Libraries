﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdFi.SecurityCompatiblity53.DataAccess.Models
{
    public class ClaimSet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClaimSetId { get; set; }

        [StringLength(255)]
        [Required]
        public string ClaimSetName { get; set; }

        [Column("Application_ApplicationId")]
        public int ApplicationId { get; set; }

        [Required]
        public Application Application { get; set; }
    }
}
