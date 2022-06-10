using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class SupervisorShiftDetail
    {
        public SupervisorShiftDetail()
        {
            SupervisorAbsences = new HashSet<SupervisorAbsence>();
            SupervisorFieldLeaderships = new HashSet<SupervisorFieldLeadership>();
            SupervisorIncidentAccidents = new HashSet<SupervisorIncidentAccident>();
            SupervisorMaintenanceNotifications = new HashSet<SupervisorMaintenanceNotification>();
            SupervisorTopIssues = new HashSet<SupervisorTopIssue>();
            SupervisorTrainings = new HashSet<SupervisorTraining>();
            SupervisorUpcomingActions = new HashSet<SupervisorUpcomingAction>();
        }

        public string Section { get; set; } = null!;
        public DateTime ShiftDate { get; set; }
        public string? Supervisor { get; set; }

        public virtual ICollection<SupervisorAbsence> SupervisorAbsences { get; set; }
        public virtual ICollection<SupervisorFieldLeadership> SupervisorFieldLeaderships { get; set; }
        public virtual ICollection<SupervisorIncidentAccident> SupervisorIncidentAccidents { get; set; }
        public virtual ICollection<SupervisorMaintenanceNotification> SupervisorMaintenanceNotifications { get; set; }
        public virtual ICollection<SupervisorTopIssue> SupervisorTopIssues { get; set; }
        public virtual ICollection<SupervisorTraining> SupervisorTrainings { get; set; }
        public virtual ICollection<SupervisorUpcomingAction> SupervisorUpcomingActions { get; set; }
    }
}
