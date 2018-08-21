using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{

    public class AdSliderDAL
    {
        const string TABLE_NAME = "ad_slider";
        const string FIELDS = "*";

       
        public List<AdSlider> GetAdSlider()
        {
            List<SimpleParameter> simpleParameters = new List<SimpleParameter>
            {
                new SimpleParameter() { Name = "isShow", Value = "1" }
            };
            //return DBHelper<AdSlider>.Select(TABLE_NAME, FIELDS);
            try
            {
                List<AdSlider> a = DBHelper<AdSlider>.Select("select * from ad_slider where isShow=1");
            }catch(Exception e){
                var abc = e.InnerException;
            }
            return null;
        }
    }
}
