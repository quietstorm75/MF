using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace MobileFinal.Models
{
    public class DocumentFiles
    {

        public string docid { get; set; }
        public string docname { get; set; }
        public string Content { get; set; }

        public string ext { get; set; }
        public string docUser { get; set; }
        public string createdby { get; set; }
        public string createDate { get; set; }
        public string modifiedDate { get; set; }
        public string modifiedby { get; set; }
        public string active { get; set; }
    }


    public class Meeting {
        public string agendaId { get; set; }
        public string agendastart { get; set;}
        public string agendaexpire { get; set; }
        public string agendadetails { get; set; }
        public string agendatitle { get; set; }
        public string frequency { get; set; }
        public string recurrence { get; set; }
        public string url { get; set; }

        public List<MeetingAttendee> attendees { get; set; }
        public List<DocumentFiles> agendadocuments { get; set;}


    }

    public class MeetingAttendee {
        public string attendeeId { get; set; }
        public string agendaId { get; set; }
        public string attendeeEmail { get; set; }
        public string active { get; set; }
    }

   
}