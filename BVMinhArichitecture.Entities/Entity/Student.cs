using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace BVMinhArichitecture.Entities.Entity
{
    public class Student : BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public Guid StudentId { get; set; }

        [BsonElement("StudentName")]
        public string StudentName { get; set; }
    }
}
