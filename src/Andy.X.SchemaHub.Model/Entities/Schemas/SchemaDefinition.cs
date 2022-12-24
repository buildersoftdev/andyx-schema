﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Andy.X.SchemaHub.Model.Entities.Schemas
{
    public class SchemaDefinition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long SchemaId { get; set; }

        public string Version { get; set; }
        public string SchemaPayload { get; set; }

        // map SchemaFileLocations from a List<string> use (,) comma as delimiter.
        public string SchemaFileLocations { get; set; }


        public DateTimeOffset CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
