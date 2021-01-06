using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Asteroidy.Models
{
    class ConvertedObject
    {public ConvertedObject() 
        { 
        
        }
        public string ID { get; set; }
        public string NeoRefID { get; set; }
        public string Name { get; set; }
        public string NameLimited { get; set; }
        public string Designation { get; set; }
        public string Url { get; set; }
        public EstimatedDiameter ED { get; set; }
        public bool IsHazardous { get; set; }
        public bool IsSentryObj { get; set; }
    }
    class EstimatedDiameter 
    { 
        public EstimatedDiameter(EDUnit km, EDUnit m, EDUnit miles, EDUnit feet) 
        {
            Km = km;
            M = m;
            Miles = miles;
            Feet = feet;
        }
        public EDUnit Km { get; set; }
        public EDUnit M { get; set; }
        public EDUnit Miles { get; set; }
        public EDUnit Feet { get; set; }
    }
    class EDUnit
    {
        public EDUnit(double min, double max)
        {
            Min = min;
            Max = max;
        }
        double Min;
        double Max;
    }
    class CloseApproachData
    {
        public CloseApproachData(string id, string cap, string capfull, double epoch) 
        { 
        
            ID = id;
            CloseApproachDate = cap;
            CloseApproachDateFull = capfull;
            EpochDateCloseApproach = epoch;

        }

        public string ID { get; set; }
        public string CloseApproachDate { get; set; }
        public string CloseApproachDateFull { get; set; }
        public double EpochDateCloseApproach { get; set; }


    }
    class RelativeVelocity 
    {
        public RelativeVelocity(string kps, string kph, string mph) 
        {
            KPS = kps;
            KPH = kph;
            MPH = mph;
        }
        public string KPS { get; set; }
        public string KPH { get; set; }
        public string MPH { get; set; }

        
    }
    class MissDistance 
    { 
        public MissDistance(string astronomical, string lunar, string km, string miles, string orbitingbody) 
        {
            Astronomical = astronomical;
            Lunar = lunar;
            Km = km;
            Miles = miles;
            OrbitingBody = orbitingbody;
        }
        public string Astronomical { get; set; }
        public string Lunar { get; set; }
        public string Km { get; set; }
        public string Miles { get; set; }
        public string OrbitingBody { get; set; }
    }
    class OrbitalData
    {
        public OrbitalData() { }
        public string OrbitID{get;set;}
        public string OrbitDeterminationDate { get; set; }
        public string FirstObservationDate { get; set; }

    
    }
}


