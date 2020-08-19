using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BeastMaster.Models
{
  public class Creature
  {
    public int CreatureId { get; set; }
    public string CreatureName { get; set; }
    public string CreatureOriginCulture { get; set; }
    public string CreatureOriginDate { get; set; }
    public string CreatureTaxonomy { get; set; }
    public string CreatureType { get; set; }
    public string CreatureAbility { get; set; }
    public string CreatureHabitat { get; set; }
    public string CreatureMorality { get; set; }
    public string CreatureDescription { get; set; }
    public string CreatureImage { get; set; }
    public string CreatureLifespan { get; set; }
    public string CreatureRelatedCreature { get; set; }
    public string CreatureNemesis { get; set; }
    public string CreatureWeakness { get; set; }

    public static List<Creature> GetCreatures()
    {
      var apiCallTast = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Creature> creatureList = JsonConvert.DeserializeObject<List<Creature>>(jsonResponse.ToString());

      return creatureList;
    }

    public static Creature GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Creature creature = JsonConvert.DeserializeObject<Creature>(jsonResponse.ToString());

      return creature;
    }

    public static void Post(Creature creature)
    {
      string jsonCreature = JsonConvert.SerializeObject(creature);
      var apiCallTask = ApiHelper.Post(jsonCreature);
    }

    public static void Put(Creature creature)
    {
      string jsonCreature = JsonConvert.SerializeObject(creature);
      var apiCallTask = ApiHelper.Put(creature.CreatureId, jsonCreature);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}