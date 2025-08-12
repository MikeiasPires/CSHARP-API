using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Data;

namespace Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewApiPersonagens : ControllerBase
    {
        private readonly AppDbContext _appDbcontext;


        public NewApiPersonagens(AppDbContext appDbContext)
        {
            _appDbcontext = appDbContext;
        }
    }
}