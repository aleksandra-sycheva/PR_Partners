using PR4_Patners.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4_Patners
{
    public partial class FormCreate : Form
    {
        private Partner? _partner;
        private Panel _panelPartners;
        private Panel? _selectedPanel;
        private int _selectedTypeIndex;
        private string _discount = "0";
        public FormCreate(ref Panel panelPartners)
        {
            InitializeComponent();
            SetupTypes();
            _panelPartners = panelPartners;
        }

        public FormCreate(ref Panel panelPartners, Panel selectedPanel, Partner partner, string discount)
        {
            InitializeComponent();

            _partner = partner;
            _panelPartners = panelPartners;
            _selectedPanel = selectedPanel;
            _discount = discount;

            SetupTypes();
            NameTextBox.Text = _partner.Name;
            LegalAdressTextBox.Text = _partner.LegalAdress;
            IINTextBox.Text = _partner.Inn;
            DirectorTextBox.Text = _partner.FiooftheDirector;
            PhoneTextBox.Text = _partner.Phone;
            EmailTextBox.Text = _partner.Email;
            RatingTextBox.Text = _partner.Rating.ToString();
        }

        private void SetupTypes()
        {
            using (Models.AppContext db = new Models.AppContext())
            {
                List<TypesOfPartner> partnerTypes = db.TypesOfPartners.OrderBy(o => o.Id).ToList();
                TypeComboBox.DataSource = partnerTypes;
                TypeComboBox.DisplayMember = "TypeOfPartner";
                TypeComboBox.ValueMember = "Id";
                if (_selectedPanel != null)
                {
                    string labelTypeAndName = _selectedPanel.Controls.Find("labelTypeAndName", true)[0].Text;
                    string typeName = labelTypeAndName.Split('|')[0];
                    int typeIndex = db.TypesOfPartners
                        .OrderBy(x => x.Id)
                        .Where(x => x.TypeOfPartner == typeName)
                        .Select(x => x.Id)
                        .First();
                    TypeComboBox.SelectedIndex = typeIndex - 1;
                }
            }
        }


        private void BttnConfirm_Click(object sender, EventArgs e)
        {
            if (_partner != null)
            {
                try
                {
                    Panel panel;
                    using (Models.AppContext db = new Models.AppContext())
                    {
                        string typeOfPartner = db.TypesOfPartners
                            .Where(x => x.Id == _selectedTypeIndex)
                            .Select(x => x.TypeOfPartner)
                            .First();

                        Partner dbPartner = db.Partners.First(x => x.Id == _partner.Id);

                        dbPartner.Id = _selectedTypeIndex;
                        dbPartner.Name = NameTextBox.Text;
                        dbPartner.LegalAdress = LegalAdressTextBox.Text;
                        dbPartner.Inn = IINTextBox.Text;
                        dbPartner.FiooftheDirector = DirectorTextBox.Text;
                        dbPartner.Phone = PhoneTextBox.Text;
                        dbPartner.Email = EmailTextBox.Text;
                        dbPartner.Rating = Int16.Parse(RatingTextBox.Text);

                        db.SaveChanges();
                    }

                }
                catch
                {
                    MessageBox.Show("Не удалось обновить запись");
                }
            }
            else
            {
                try
                {
                    Panel panel;
                    using (Models.AppContext db = new Models.AppContext())
                    {
                        string typeOfPartner = db.TypesOfPartners
                            .Where(x => x.Id == _selectedTypeIndex)
                            .Select(x => x.TypeOfPartner)
                            .First();

                        
                        Partner partner = new Partner();

                       
                        partner.Id = db.Partners
                            .OrderByDescending(x => x.Id)
                            .Select(x => x.Id)
                            .First() + 1;
                        partner.Id = _selectedTypeIndex;
                        partner.Name = NameTextBox.Text;
                        partner.LegalAdress = LegalAdressTextBox.Text;
                        partner.Inn = IINTextBox.Text;
                        partner.FiooftheDirector = DirectorTextBox.Text;
                        partner.Phone = PhoneTextBox.Text;
                        partner.Email = EmailTextBox.Text;
                        partner.Rating = Int16.Parse(RatingTextBox.Text);

                        db.Partners.Add(partner);
                        db.SaveChanges();

                        
                        int idOfPartner = db.Partners
                            .Where(x => x.Inn == partner.Inn)
                            .Select(x => x.Id)
                            .First();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось создать запись:" +
                        $"\n{ex.Message}");
                }
            }
            this.Close();
        }

        private void TypeComboBox_TextChanged(object sender, EventArgs e)
        {
            _selectedTypeIndex = TypeComboBox.SelectedIndex + 1;
        }
    }


}
