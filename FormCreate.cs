using Npgsql.Internal.Postgres;
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
            try
            {
                using (Models.AppContext db = new Models.AppContext())
                {
                    if (_partner != null) // Редактирование существующего партнера
                    {
                        Partner dbPartner = db.Partners.First(x => x.Id == _partner.Id);
                        dbPartner.Name = NameTextBox.Text;
                        dbPartner.LegalAdress = LegalAdressTextBox.Text;
                        dbPartner.Inn = IINTextBox.Text;
                        dbPartner.FiooftheDirector = DirectorTextBox.Text;
                        dbPartner.Phone = PhoneTextBox.Text;
                        dbPartner.Email = EmailTextBox.Text;
                        dbPartner.Rating = Convert.ToInt16(RatingTextBox.Text);
                        dbPartner.IdTypeOfPerther = (short)((short)TypeComboBox.SelectedIndex + 1); // Обновление типа партнера

                        db.SaveChanges();
                    }
                    else // Добавление нового партнера
                    {
                        try
                        {
                            Partner partner = new Partner
                            {
                                Name = NameTextBox.Text,
                                LegalAdress = LegalAdressTextBox.Text,
                                Inn = IINTextBox.Text,
                                FiooftheDirector = DirectorTextBox.Text,
                                Phone = PhoneTextBox.Text,
                                Email = EmailTextBox.Text,
                                Rating = Convert.ToInt16(RatingTextBox.Text),
                                IdTypeOfPerther = (short)((short)TypeComboBox.SelectedIndex + 1) // Установка типа партнера
                            };

                           
                            db.Partners.Add(partner);
                            db.SaveChanges(); // Сохранение изменений в базе данных
                            MessageBox.Show("Партнер успешно добавлен!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не удалось сохранить запись: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить запись: " + ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
