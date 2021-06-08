using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG6221_ICE2_19014225_NEW_
{
    public partial class CovidForm : Form
    {

        Info inf = new Info();

        //variables to be added to array
        private static string ID;
        private static string MedAid;
        private static string Name;
        private static string Surname;
        private static string docRef;
        private static char bloodType;
        private static string allergies;
        private static bool hadCovid;
        private static string vaccine;

        public CovidForm()
        {

            InitializeComponent();
        }

        
        private void ItemsListHospital()
        {
            lblHOutput.Items.Clear();
            string strTemp = String.Format("Hospital Info: ");
            lblHOutput.Items.Add(strTemp);

            strTemp = String.Format("----------------------------------------------");
            lblHOutput.Items.Add(strTemp);

            strTemp = String.Format("Hospital Name: " + inf.getHospital_Name());
            lblHOutput.Items.Add(strTemp);

            strTemp = String.Format("Address: " + inf.getAddress());
            lblHOutput.Items.Add(strTemp);

            strTemp = String.Format("Hospital Type: " + inf.getType());
            lblHOutput.Items.Add(strTemp);

            strTemp = String.Format("Province: " + inf.getProvince());
            lblHOutput.Items.Add(strTemp);
        }

        private void ItemsListPatient()
        {
            lblPOutput.Items.Clear();
            string strTemp = String.Format("Patient Info: ");
            lblPOutput.Items.Add(strTemp);

            strTemp = String.Format("----------------------------------------------");
            lblPOutput.Items.Add(strTemp);

            strTemp = String.Format("ID: " + inf.getID());
            lblPOutput.Items.Add(strTemp);

            strTemp = String.Format("Medical Aid: " + inf.getMedicalAid());
            lblPOutput.Items.Add(strTemp);

            strTemp = String.Format("Name: " + inf.getName());
            lblPOutput.Items.Add(strTemp);

            strTemp = String.Format("Surname: " + inf.getSurname());
            lblPOutput.Items.Add(strTemp);

            strTemp = String.Format("Doctor: " + inf.getRefDr());
            lblPOutput.Items.Add(strTemp);

            strTemp = String.Format("Blood Type: " + inf.getBloodType());
            lblPOutput.Items.Add(strTemp);

            strTemp = String.Format("Allergies: " + inf.getAllergies());
            lblPOutput.Items.Add(strTemp);

            strTemp = String.Format("Covid Positive: " + inf.getCovidPostive());
            lblPOutput.Items.Add(strTemp);

            strTemp = String.Format("Vaccine: " + inf.getCovidPostive());
            lblPOutput.Items.Add(strTemp);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHospital.Text = String.Empty;
            txtProvince.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPorP.Text = String.Empty;

            txtIDnum.Text = String.Empty;
            txtMedAid.Text = String.Empty;
            txtName.Text = String.Empty;
            txtSurname.Text = String.Empty;
            txtDoc.Text = String.Empty;
            txtBlood.Text = String.Empty;
            txtAllergies.Text = String.Empty;
            txtCovid.Text = String.Empty;
            txtVaccine.Text = String.Empty;
            numPatient.Value = 0;

            lblHOutput.Items.Clear();
            lblPOutput.Items.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Pass values through to variables
            inf.setID(txtIDnum.Text);
            inf.setMedicalAid(txtMedAid.Text);
            inf.setName(txtName.Text);
            inf.setSurame(txtSurname.Text);
            inf.setRefDr(txtDoc.Text);
            inf.setBloodType(Convert.ToChar(txtBlood.Text));
            inf.setAllergies(txtAllergies.Text);
            inf.setCovidPostive(txtCovid.Text);
            inf.setVaccine(txtVaccine.Text);
            inf.setHospital_Name(txtHospital.Text);
            inf.setAddress(txtAddress.Text);
            inf.setType(txtPorP.Text);
            inf.setProvince(txtProvince.Text);
            //Display details in output text box
            ItemsListHospital();
            ItemsListPatient();
        }

    }
}
