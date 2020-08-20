using BeastClient.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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