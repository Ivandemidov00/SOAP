using Application.Interfaces;
using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Services;

namespace Web
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
       /* private readonly IUnitOfWork unitOfWork;

        public WebService(IUnitOfWork unitOfWork)
        {
          //  this.unitOfWork = unitOfWork;
        }*/
        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }
        [WebMethod]
        public Task<IReadOnlyList<Service>> Go()
        {
            //List<Int32> list = new List<Int32>();
            var data = unitOfWork.Services.GetAllAsync();
            return data;
        }
    }
}
