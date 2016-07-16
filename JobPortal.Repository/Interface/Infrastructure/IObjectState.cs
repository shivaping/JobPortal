
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Repository.Interface.Infrastructure
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}