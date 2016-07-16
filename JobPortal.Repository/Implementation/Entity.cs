using System.ComponentModel.DataAnnotations.Schema;
using JobPortal.Repository.Interface.Infrastructure;

namespace JobPortal.Repository.Implementation
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}