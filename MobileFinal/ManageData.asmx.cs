using MobileFinal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MobileFinal
{
    /// <summary>
    /// Summary description for Manage
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Manage : System.Web.Services.WebService
    {      

            DocumentFiles doc = new DocumentFiles()
            {
                active = "1",
                modifiedby = "gdennis",
                Content = "the quick brown fox jumped over the lazt dog"
                ,
                createDate = DateTime.Now.ToShortDateString(),
                createdby = "gdennis",
                docid = "4",
                docname = "brownfox.txt",
                docUser = "mary brown",
                ext = "txt",
                modifiedDate = DateTime.Now.ToShortDateString()

            };
            DocumentFiles doc2 = new DocumentFiles()
            {
                active = "1",
                modifiedby = "gdennis",
                Content = "Sarah lee is a donut maker"
                ,
                createDate = DateTime.Now.ToShortDateString(),
                createdby = "gdennis",
                docid = "41",
                docname = "sarah.txt",
                docUser = "orlando brown",
                ext = "txt",
                modifiedDate = DateTime.Now.ToShortDateString()

            };

            DocumentFiles doc3 = new DocumentFiles()
            {
                active = "1",
                modifiedby = "gdennis",
                Content = "Samuel l jackson is the greatest actor ever",
                createDate = DateTime.Now.ToShortDateString(),
                createdby = "mgibbs",
                docid = "14",
                docname = "sammj.txt",
                docUser = "brown water",
                ext = "txt",
                modifiedDate = DateTime.Now.ToShortDateString()

            };

            List<DocumentFiles> docs = new List<DocumentFiles>();

            MeetingAttendee attendee = new MeetingAttendee()
            {
                active = "1",
                agendaId = "22",
                attendeeEmail = "sasha@nymcu.org",
                attendeeId = "36"
            };

            MeetingAttendee attendee1 = new MeetingAttendee()
            {
                active = "1",
                agendaId = "33",
                attendeeEmail = "marsha@nymcu.org",
                attendeeId = "11"
            };
            MeetingAttendee attendee2 = new MeetingAttendee()
            {
                active = "1",
                agendaId = "5",
                attendeeEmail = "andrea@nymcu.org",
                attendeeId = "13"
            };
            MeetingAttendee attendee3 = new MeetingAttendee()
            {
                active = "1",
                agendaId = "5",
                attendeeEmail = "makr@nymcu.org",
                attendeeId = "18"
            };
            MeetingAttendee attendee4 = new MeetingAttendee()
            {
                active = "1",
                agendaId = "22",
                attendeeEmail = "Larry@nymcu.org",
                attendeeId = "30"
            };

            List<MeetingAttendee> attendees = new List<MeetingAttendee>();



            List<Meeting> meetings = new List<Meeting>();

            [WebMethod]
            public string GetServiceSpecificMeeting(string userid, string mtgid)
            {

                docs.Add(doc);
                docs.Add(doc2);
                docs.Add(doc3);

                attendees.Add(attendee);
                attendees.Add(attendee1);
                attendees.Add(attendee2);
                attendees.Add(attendee3);
                attendees.Add(attendee4);

                Meeting mtg = new Meeting()
                {
                    agendadetails = "Board Meeting about elections",
                    agendaId = "22",
                    agendastart = DateTime.Now.AddDays(10).ToShortDateString(),
                    agendaexpire = DateTime.Now.AddDays(10).AddHours(1).ToShortDateString(),
                    url = "http://gotomeeting01.com,http://www.gotomeeting03.com",
                    agendatitle = "Board Meeting",
                    frequency = "None",
                    recurrence = "",
                    agendadocuments = docs,
                    attendees = attendees
                };


            return JsonConvert.SerializeObject(mtg).ToString();
            }
        }
    
}
