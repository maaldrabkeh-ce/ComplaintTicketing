using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace ComplaintTicketing.Controllers
{
    public class DemandController : Controller
    {
        // GET: DemandController

        [HttpGet]
        public DemandViewModel Index()
        {
            DemandViewModel viewModel = new DemandViewModel();
            return viewModel;
        }

        // POST: ComplaintController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public bool Create(DemandViewModel viewModel)
        {
            try
            {
                // Process viewModel and save data
                return true;
            }
            catch
            {
                return false;
            }
        }


        // POST: ComplaintController/Edit/5
        [HttpPut]
        [ValidateAntiForgeryToken]
        public bool Edit(DemandViewModel viewModel)
        {
            try
            {
                // Process viewModel and save data
                return true;
            }
            catch
            {
                return false;
            }
        }


        // POST: ComplaintController/Delete/5
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public bool Delete(Guid id)
        {
            try
            {
                // Process viewModel and delete data
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
