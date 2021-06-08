using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ICE2_19014225_NEW_
{
    class Info
    {

        //Variables for Hospital details
        private static String Hospital_Name;
        private static String Address;
        private static String Type;//private or public hospital
        private static String Province;

        //Variables for Patient details
        private static String ID;
        private static String MedicalAid;
        private static String Name;
        private static String Surname;
        private static String RefDr;
        private static Char BloodType;
        private static String Allergies;
        private static String CovidPostive;
        private static String Vaccine;


        //Get and sets for Hospital
        public void setHospital_Name(String hospitalName)
        {
            Hospital_Name = hospitalName;
        }

        public String getHospital_Name()
        {
            return Hospital_Name;
        }

        public void setAddress(String address)
        {
            Address = address;
        }

        public String getAddress()
        {
            return Address;
        }

        public void setType(String hosType)
        {
            Type = hosType;
        }

        public String getType()
        {
            return Type;
        }

        public void setProvince(String province)
        {
            Province = province;
        }

        public String getProvince()
        {
            return Province;
        }
        

        //Get and sets for Patient
        public void setID(string iD)
        {
            ID = iD;
        }


        public string getID()
        {
            return ID;
        }

        public void setMedicalAid(string medicalAid)
        {
            MedicalAid = medicalAid;
        }


        public string getMedicalAid()
        {
            return MedicalAid;
        }

        public void setName(string name)
        {
            Name = name;
        }


        public string getName()
        {
            return Name;
        }

        public void setSurame(string surname)
        {
            Surname = surname;
        }


        public string getSurname()
        {
            return Surname;
        }

        public void setRefDr(string refDr)
        {
            RefDr = refDr;
        }


        public string getRefDr()
        {
            return RefDr;
        }

        public void setBloodType(char bloodType)
        {
            BloodType = bloodType;
        }


        public char getBloodType()
        {
            return BloodType;
        }

        public void setAllergies(string allergies)
        {
            Allergies = allergies;
        }


        public string getAllergies()
        {
            return Allergies;
        }

        public void setCovidPostive(string hadcovid)
        {
            CovidPostive = hadcovid;
        }


        public string getCovidPostive()
        {
            return CovidPostive;
        }

        public void setVaccine(string vac)
        {
            Vaccine = vac;
        }


        public string getVaccine()
        {
            return Vaccine;
        }
        
    }
}
