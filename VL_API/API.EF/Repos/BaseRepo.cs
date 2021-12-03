using API.core.Interface;
using API.core.Models;
using API.core.Vmodels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.EF.Repos
{
   public  class BaseRepo : IBase<Request> 
    {
        private API_Context _db;
        string Path = Directory.GetCurrentDirectory();
        string[] done, duplicates, failed;
        public BaseRepo(API_Context db)
        {
              _db = db;
        }
        public Result Add(RequestVM rq)
        {
            if (_db.Requests.FirstOrDefault(x => x.mobileNumber == int.Parse(rq.MobileNo)) != null)
            {
                duplicates = new string[] { rq.MobileNo };
                File.AppendAllLines(Path+@"\Service\duplicates.txt", duplicates);
                return new Result() { Status = 2, message = "MobileNumber was added before" };

            }
            Request req = new Request();
            req.mobileNumber = int.Parse(rq.MobileNo);
            req.requestDate = DateTime.Now;
            _db.Requests.Add(req);
            try
            {
               _db.SaveChanges();
                done = new string[] { rq.MobileNo };
                File.AppendAllLines(Path + @"\Service\done.txt", done);
                return new Result() { Status = 1, message = "Request Is Added" };
            }
            catch (Exception ex)
            {
                failed = new string[] { rq.MobileNo };
                File.AppendAllLines(Path + @"\Service\failed.txt", failed);
                return new Result() { Status = 3, message = "An Error Occured" };
            }
        }

        public async Task<List<Request>> GetAll()
        {
            return await _db.Requests.ToListAsync();
        }
    }
}
