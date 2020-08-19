using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeastClient.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;  

namespace BeastClient.Controllers
{
    public class CreaturesController : Controller
    {  
      public IActionResult Index()
      {
        var allCreatures = Creature.GetCreatures();
        return View(allCreatures);
      }

      public IActionResult Details(int id)
      {
        var creature = Creature.GetDetails(id);
        return View(creature);
      }
    }
}