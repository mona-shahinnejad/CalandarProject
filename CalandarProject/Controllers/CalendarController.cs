using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using CalandarProject.Models;
using Common.Extentions;
using Services.DTO;
using Services.IService;

namespace CalandarProject.Controllers
{
    public class CalendarController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAppointmentService _appointmentService;

        public CalendarController(IMapper mapper, IAppointmentService appointmentService)
        {
            _mapper = mapper;
            _appointmentService = appointmentService;
        }

        public ActionResult Index(int month)
        {
            month = month <= 0 || month >= 13 ? 1 : month;

            var viewModel = new CalendarViewModel
            {
                Months = DateTimeExtextions.GetFullMonthNames(),
                SelectedMonth = month,
                AppointmentDetails = _mapper.Map<List<AppointmentViewModel>>(_appointmentService.GetAppointmetsByMonth(month).ToList())
            };

            return View(viewModel);
        }
    }
}