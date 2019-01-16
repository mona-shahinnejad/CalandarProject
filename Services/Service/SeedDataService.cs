using System;
using System.Collections.Generic;
using System.Linq;
using Common.Utilities;
using Domain;
using Domain.Entities;
using Services.IService;

namespace Services.Service
{
    internal class SeedDataService : ISeedDataService
    {
        private readonly CalendarDatabaseContext _context;

        public SeedDataService(CalendarDatabaseContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            if (!_context.Users.Any())
            {
                var user1 = _context.Users.Create();

                user1 = new User
                {
                    FirstName = "Sara",
                    LastName = "Muller",
                    Email = "sara.muller@gmail.com",
                    IsActive = true,
                    Password = Cryptography.Base64Encrypt("123"),
                };

                _context.Users.Add(user1);

                var user2 = _context.Users.Create();

                user2 = new User
                {
                    FirstName = "David",
                    LastName = "Luca",
                    Email = "David.Luca@gmail.com",
                    IsActive = true,
                    Password = Cryptography.Base64Encrypt("123"),
                };

                _context.Users.Add(user2);

                var user3 = _context.Users.Create();

                user3 = new User
                {
                    FirstName = "Artur",
                    LastName = "Lodovski",
                    Email = "Artur.Lodovski@gmail.com",
                    IsActive = true,
                    Password = Cryptography.Base64Encrypt("123"),
                };

                _context.Users.Add(user3);

                var user4 = _context.Users.Create();

                user4 = new Domain.Entities.User
                {
                    FirstName = "Maria",
                    LastName = "Babian",
                    Email = "maria.babian@gmail.com",
                    IsActive = true,
                    Password = Cryptography.Base64Encrypt("123"),
                };

                _context.Users.Add(user4);

                var user5 = _context.Users.Create();

                user5 = new User
                {
                    FirstName = "Michel",
                    LastName = "Sanz",
                    Email = "michel.sanz@gmail.com",
                    IsActive = true,
                    Password = Cryptography.Base64Encrypt("123"),
                };

                _context.Users.Add(user5);

                _context.SaveChanges();

                var appointment1 = _context.Appointments.Create();

                appointment1 = new Appointment
                {
                    AppointmentDateTime = new DateTime(2019, 01, 15, 10, 30, 0),
                    Title = "Project Planning",
                    Description = "Start of sprint #21, planning",
                    Organizer = user1,
                };
                appointment1.Attendees.Add(user1);
                appointment1.Attendees.Add(user2);
                appointment1.Attendees.Add(user3);

                _context.Appointments.Add(appointment1);

                var appointment2 = _context.Appointments.Create();

                appointment2 = new Appointment
                {
                    AppointmentDateTime = new DateTime(2019, 01, 27, 10, 00, 00),
                    Title = "Sprint Demo",
                    Description = "Demo of sprint #21",
                    Organizer = user1,
                };
                appointment2.Attendees.Add(user1);
                appointment2.Attendees.Add(user2);
                appointment2.Attendees.Add(user3);

                _context.Appointments.Add(appointment2);

                var appointment3 = _context.Appointments.Create();

                appointment3 = new Appointment
                {
                    AppointmentDateTime = new DateTime(2019, 01, 27, 11, 00, 00),
                    Title = "Retrospective",
                    Description = "Retrospective of sprint #21",
                    Organizer = user1,
                };
                appointment3.Attendees.Add(user1);
                appointment3.Attendees.Add(user2);
                appointment3.Attendees.Add(user3);

                _context.Appointments.Add(appointment3);

                var appointment4 = _context.Appointments.Create();

                appointment4 = new Appointment
                {
                    AppointmentDateTime = new DateTime(2019, 01, 28, 10, 30, 0),
                    Title = "Project Planning",
                    Description = "Start of sprint #22, planning",
                    Organizer = user1,
                };
                appointment4.Attendees.Add(user1);
                appointment4.Attendees.Add(user2);
                appointment4.Attendees.Add(user3);

                _context.Appointments.Add(appointment4);

                var appointment5 = _context.Appointments.Create();

                appointment5 = new Appointment
                {
                    AppointmentDateTime = new DateTime(2019, 02, 10, 10, 00, 00),
                    Title = "Sprint Demo",
                    Description = "Demo of sprint #22",
                    Organizer = user1,
                };
                appointment5.Attendees.Add(user1);
                appointment5.Attendees.Add(user2);
                appointment5.Attendees.Add(user3);

                _context.Appointments.Add(appointment5);

                var appointment6 = _context.Appointments.Create();

                appointment6 = new Appointment
                {
                    AppointmentDateTime = new DateTime(2019, 02, 10, 11, 00, 00),
                    Title = "Retrospective",
                    Description = "Retrospective of sprint #22",
                    Organizer = user1,
                };
                appointment6.Attendees.Add(user1);
                appointment6.Attendees.Add(user2);
                appointment6.Attendees.Add(user3);

                _context.Appointments.Add(appointment6);

                var appointment7 = _context.Appointments.Create();

                appointment7 = new Appointment
                {
                    AppointmentDateTime = new DateTime(2019, 02, 03, 10, 30, 0),
                    Title = "Client Meeting",
                    Description = "Client meeting for analysing Tasks",
                    Organizer = user1,
                };
                appointment7.Attendees.Add(user1);
                appointment7.Attendees.Add(user2);
                appointment7.Attendees.Add(user3);


                _context.SaveChanges();
            }
        }
    }
}
