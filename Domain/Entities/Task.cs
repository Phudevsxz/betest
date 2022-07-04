using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Task:BaseEntity<Guid>
    {
        public enum statusTypes
        {
            New,
            Inprogress,
            Finished
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public statusTypes statusType { get; set; }
        public Guid ProjectId { get; set; }
        public Guid AssignedUserId { get; set; }
        public Project Project { get; set; }
        public User AssignedUser { get; set; }
    }
}
