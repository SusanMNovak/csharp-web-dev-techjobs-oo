﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        public CoreCompetency(string value) : base(value) { }
    }


    /*public class CoreCompetency
    {
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }

        // TODO: Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
            Id = nextId;
            nextId++;
        }        

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator CoreCompetency(string v)
        {
            throw new NotImplementedException();
        }
    }*/
    
}
