using System;
using System.Collections.Generic;
using System.Text;

namespace Resala.Apps.Domain.CommonModels
{
    public enum EducationLevel { ELEMENTARY, PRIMARY, SECONDARY, UNIVERSITY, GRADUATE }
    public enum Role { PARTICIPANT, TRAINEE, MEMBER, TEAM_LEADER, BRANCH_MANAGER, EXCUTIVE_MANAGER, GENERAL_MANAGER }
    public enum UserPrivilege { ADMIN, EDITOR }
    public enum Gender { MALE, FEMALE }

    class Volunteer : BaseObject
    {
        public DateTime BirthDate { get; set; }
        public DateTime JoinDate { get; set; }
        public string IdentificationNumber { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string WhatsAppNumber { get; set; }
        public Region Region { get; set; }
        public CellularNetwork CellularNetwork { get; set; }
        public Branch Branch { get; set; }
        public Specialization Education { get; set; }
        public Gender Gender { get; set; }
        public bool MiniCamp { get; set; }
        public bool Tshirt { get; set; }


    }
}
