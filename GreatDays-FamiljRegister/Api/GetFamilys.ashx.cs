using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Register_Data;
using GreatDays_FamiljRegister.Models;

namespace GreatDays_FamiljRegister.Api
{
    /// <summary>
    /// Summary description for GetFamilys
    /// </summary>
    public class GetFamilys : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/json";

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<FamilyModel> familys = new List<FamilyModel>();
            using (MainDB db = new MainDB())
            {


                foreach (var item in db.Familys)
                {
                    List<CarModel> cm = new List<CarModel>();
                    foreach (var car in item.Cars.Where(c => c.FamilyId == item.FamilyId))
                    {
                        cm.Add(new CarModel
                        {
                            Name = car.Name,
                            CarId = car.CarId,
                            FamilyId = item.FamilyId,
                            RegistratioNnumber = car.RegistratioNnumber,
                            Year = car.Year
                        });
                    }
                    List<EstateModel> em = new List<EstateModel>();
                    foreach (var estate in item.Estates.Where(e => e.FamilyId ==item.FamilyId))
                    {
                        em.Add(new EstateModel { Address = estate.Address, County = estate.County, EstateId = estate.EstateId, FamilyId = estate.FamilyId });
                    }
                  

                    List<PersonModel> pm = new List<PersonModel>();
                    foreach (var person in item.Persons.Where(p => p.FamilyId == item.FamilyId))
                    {
                        List<BankAssetModel> bm = new List<BankAssetModel>();
                        foreach (var bankasset in person.BankAssets.Where(b => b.PersonId == person.PersonId))
                        {
                            bm.Add(new BankAssetModel { Asset = bankasset.Asset, BankAssetId = bankasset.BankAssetId, PersonId = bankasset.PersonId });
                        }
                        pm.Add(new PersonModel { Name = person.Name, PersonId =person.PersonId, FamilyId = person.FamilyId, Age = person.Age, BankAssets = bm });
                    }

                    familys.Add(new FamilyModel()
                    {
                        LastName = item.LastName,
                        FamilyId = item.FamilyId,
                        Cars = cm,
                        Estates = em,
                        Persons = pm,
                    });
                }
                context.Response.Write(serializer.Serialize(familys));
            }

        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}