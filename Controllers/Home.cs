using System.IO;
using MyWebsite.Model;
namespace MyWebsite.Controllers
{
    class Home : Controller
    {
        private Model db = new Model();

        public ActionResult Home(){
            return View();
        }

        public ActionResult getCustomer(){
            var customer = from c in db.Customer
                            select c;                
            return customer.toList();
        }

        public ActionResult Add(){

        }

        public ActionResult Update(string customerId){

        }
        public ActionResult Delete(string customer Id){

        }
    }
}