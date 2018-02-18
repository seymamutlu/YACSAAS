using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using YACSAAS.Repository.Database;
using YACSAAS.Web.Services;

namespace YACSAAS.Web.Controllers
{
    public class VehicleController : ApiController
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        // GET: Vehicles
        public IEnumerable<Vehicle> Index()
        {
            return _vehicleService.GetAll();
        }

        // GET: Vehicles/Details/5
        public Vehicle Details(int id)
        {
            var vehicle = _vehicleService.GetById(id);
            if (vehicle == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return vehicle;
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public HttpResponseMessage Create([Bind(Include = "Id,LicensePlate,ManufacturerId,VehicleTypeId")]
            Vehicle vehicle)
        {
            HttpResponseMessage response;
            if (ModelState.IsValid)
            {
                _vehicleService.Create(vehicle);
                response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }

            response = Request.CreateResponse(HttpStatusCode.BadRequest);

            return response;
        }


        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public HttpResponseMessage Edit([Bind(Include = "Id,LicensePlate,ManufacturerId,VehicleTypeId")]
            Vehicle vehicle)
        {
            HttpResponseMessage response;

            if (ModelState.IsValid)
            {
                try
                {
                    _vehicleService.Update(vehicle);
                    response = Request.CreateResponse(HttpStatusCode.OK);
                    return response;
                }
                catch (Exception ex)
                {
                    response = Request.CreateResponse(HttpStatusCode.BadRequest);
                    response.Content = new StringContent(ex.ToString(), Encoding.UTF8, "application/json");
                }
            }
            response = Request.CreateResponse(HttpStatusCode.BadRequest);
            return response;

        }


        // POST: Vehicles/Delete/5
        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public HttpResponseMessage DeleteConfirmed(int id)
        {
            HttpResponseMessage response;
            try
            {
                var vehicle = _vehicleService.GetById(id);
                _vehicleService.Delete(vehicle);
                response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                response = Request.CreateResponse(HttpStatusCode.BadRequest);
                response.Content = new StringContent(e.ToString(), Encoding.UTF8, "application/json");
            }

            return response;
        }
    }
}